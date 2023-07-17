defmodule Solution do
  @spec arrange_coins(n :: integer) :: integer
  def arrange_coins(n) do
    recurse(n, 1, 0)
  end
  
  defp recurse(n, row_length, acc) when n <= 0 do 
    acc
  end

  defp recurse(n, row_length, acc) when row_length > n do 
    acc
  end

  defp recurse(n, row_length, acc) do
    recurse(n - row_length, row_length + 1, acc + 1)
  end
end

IO.inspect(Solution.arrange_coins(1))
IO.inspect(Solution.arrange_coins(3))
IO.inspect(Solution.arrange_coins(5))
IO.inspect(Solution.arrange_coins(6))
IO.inspect(Solution.arrange_coins(8))