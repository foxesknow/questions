using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TradingProfit
    {
        enum OrderAction
        {
            Buy,
            Bid,
            Sell,            
            Offer
        }

        record struct Order
        {
            public Order(OrderAction orderAction, int size, int price)
            {
                OrderAction = orderAction;
                Size = size;
                Price = price;
            }

            public OrderAction OrderAction{get; init;}
            public int Size{get; init;}
            public int Price{get; init;}
        }

        class PriceLevel
        {
            public PriceLevel(int price)
            {
                this.Price = price;
            }

            public int Price{get;}
            public List<Order> Orders{get;} = new();
        }

        class OrderBook
        {
            private readonly List<PriceLevel> m_Buy = new();
            private readonly List<PriceLevel> m_Sell = new();

            public int Profit{get; private set;}

            public void Match(Order order)
            {
                if(order.OrderAction == OrderAction.Buy || order.OrderAction == OrderAction.Bid)
                {
                    Profit += MatchWithSellSide(order);
                }
                else
                {
                    Profit += MatchWithBuySide(order);
                }
            }

            public (int Long, int Short) CalculateExposure()
            {
                var @long = m_Buy.SelectMany(level => level.Orders)
                                 .Where(order => order.OrderAction == OrderAction.Buy)
                                 .Select(order => order.Price * order.Size)
                                 .Sum();

                var @short= m_Sell.SelectMany(level => level.Orders)
                                  .Where(order => order.OrderAction == OrderAction.Sell)
                                  .Select(order => order.Price * order.Size)
                                  .Sum();

                return (@long, @short);
            }

            public int MatchWithBuySide(Order sellOrder)
            {
                int profit = 0;

                for(var priceLevelIndex = 0; priceLevelIndex < m_Buy.Count; priceLevelIndex++)
                {
                    if(sellOrder.Size == 0) break;
                    var level = m_Buy[priceLevelIndex];
                    if(sellOrder.Price > level.Price) break;

                    var i = 0;
                    while(i < level.Orders.Count)
                    {
                        if(sellOrder.Size == 0) break;
                        var buy = level.Orders[i];

                        // We can match at this level
                        var quantityToMatch = Math.Min(sellOrder.Size, buy.Size);

                        if(IsProfitTrade(buy, sellOrder))
                        {
                            var thisProfit = quantityToMatch * Math.Abs(sellOrder.Price - buy.Price);
                            profit += thisProfit;
                        }

                        sellOrder = sellOrder with {Size = sellOrder.Size - quantityToMatch};
                        buy = buy with {Size = buy.Size - quantityToMatch};

                        if(buy.Size == 0)
                        {
                            level.Orders.RemoveAt(i);
                        }
                        else
                        {
                            level.Orders[i] = buy;
                            i++;
                        }
                    }
                }

                // If there's anything left on the order then add it to the buy side
                if(sellOrder.Size > 0)
                {
                    var updated = false;
                    for(var i = 0; i < m_Sell.Count && !updated; i++)
                    {
                        var level = m_Sell[i];

                        if(sellOrder.Price == level.Price)
                        {
                            level.Orders.Add(sellOrder);
                            updated = true;
                        }
                        else if(sellOrder.Price < level.Price)
                        {
                            var newLevel = new PriceLevel(sellOrder.Price);
                            newLevel.Orders.Add(sellOrder);
                            m_Sell.Insert(i, newLevel);
                            updated = true;
                        }
                    }

                    if(!updated)
                    {
                        var newLevel = new PriceLevel(sellOrder.Price);
                        newLevel.Orders.Add(sellOrder);
                        m_Sell.Add(newLevel);
                    }
                }

                return profit;
            }

            public int MatchWithSellSide(Order buyOrder)
            {
                int profit = 0;

                for(var priceLevelIndex = 0; priceLevelIndex < m_Sell.Count; priceLevelIndex++)
                {
                    if(buyOrder.Size == 0) break;

                    var level = m_Sell[priceLevelIndex];
                    if(buyOrder.Price < level.Price) break;

                    var i = 0;
                    while(i < level.Orders.Count)
                    {
                        if(buyOrder.Size == 0) break;
                        

                        var sell = level.Orders[i];

                        // We can match at this level
                        var quantityToMatch = Math.Min(buyOrder.Size, sell.Size);

                        if(IsProfitTrade(buyOrder, sell))
                        {
                            var thisProfit = quantityToMatch * Math.Abs(buyOrder.Price - sell.Price);
                            profit += thisProfit;
                        }

                        buyOrder = buyOrder with {Size = buyOrder.Size - quantityToMatch};
                        sell = sell with {Size = sell.Size - quantityToMatch};

                        if(sell.Size == 0)
                        {
                            level.Orders.RemoveAt(i);
                        }
                        else
                        {
                            level.Orders[i] = sell;
                            i++;
                        }
                    }
                }

                // If there's anything left on the order then add it to the buy side
                if(buyOrder.Size > 0)
                {
                    var updated = false;
                    for(var i = 0; i < m_Buy.Count && !updated; i++)
                    {
                        var level = m_Buy[i];

                        if(buyOrder.Price == level.Price)
                        {
                            level.Orders.Add(buyOrder);
                            updated = true;
                        }
                        else if(buyOrder.Price > level.Price)
                        {
                            var newLevel = new PriceLevel(buyOrder.Price);
                            newLevel.Orders.Add(buyOrder);
                            m_Buy.Insert(i, newLevel);
                            updated = true;
                        }
                    }

                    if(!updated)
                    {
                        var newLevel = new PriceLevel(buyOrder.Price);
                        newLevel.Orders.Add(buyOrder);
                        m_Buy.Add(newLevel);
                    }
                }

                return profit;
            }

            private bool IsProfitTrade(Order buy, Order sell)
            {
                return (buy.OrderAction, sell.OrderAction) switch
                {
                    (OrderAction.Buy, OrderAction.Offer) => true,
                    (OrderAction.Bid, OrderAction.Sell) => true,
                    _ => false
                };
            }
        }

        public static (int profit, int longExposure, int shortExposure) Trade(List<string> records)
        {
            var orderBooks = new Dictionary<string, OrderBook>();

            foreach(var record in records)
            {
                foreach(var (share, order) in ParseRecord(record))
                {
                    if(orderBooks.TryGetValue(share, out var book) == false)
                    {
                        book = new();
                        orderBooks.Add(share, book);
                    }

                    book.Match(order);
                }
            }

            var profit = 0;
            var @long = 0;
            var @short = 0;

            foreach(var book in orderBooks.Values)
            {
                profit += book.Profit;
                var (l, s) = book.CalculateExposure();
                @long += l;
                @short += s;
            }

            return (profit, @long, @short);
        }

        private static IEnumerable<(string Share, Order Order)> ParseRecord(string record)
        {
                Console.WriteLine(record);
            var parts = record.Split(' ');

            var share = parts[0];

            for(var i = 1; i < parts.Length; i += 3)
            {
                var action = parts[i] switch
                {
                    "OFFER" => OrderAction.Offer,
                    "SELL"  => OrderAction.Sell,
                    "BUY"   => OrderAction.Buy,
                    "BID"   => OrderAction.Bid,
                    _       => throw new Exception("unknown action")
                };

                var size = int.Parse(parts[i + 1]);
                var price = int.Parse(parts[i + 2]);

                yield return (share, new(action, size, price));
            }
        }
    }
}
