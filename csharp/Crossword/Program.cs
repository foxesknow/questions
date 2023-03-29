using System;
using System.Collections.Generic;

namespace Crossword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoWords();
            DoFood();
            DoHolidays();
        }

        private static void DoWords()
        {
            var puzzle = "2001\n0..0\n1000\n0..0";
            var words = new[]{"casa", "alan", "ciao", "anta"};

            Solve(puzzle, words);
        }

        private static void DoFood()
        {
            var puzzle = @" ..1.1..1...
                            10000..1000
                            ..0.0..0...
                            ..1000000..
                            ..0.0..0...
                            1000..10000
                            ..0.1..0...
                            ....0..0...
                            ..100000...
                            ....0..0...
                            ....0......";

            var words = new[]
            {
                "popcorn",
                "fruit",
                "flour",
                "chicken",
                "eggs",
                "vegetables",
                "pasta",
                "pork",
                "steak",
                "cheese"
            };

            Solve(puzzle, words);
        }

        private static void DoHolidays()
        {
            var puzzle = @" ...1...........
                            ..1000001000...
                            ...0....0......
                            .1......0...1..
                            .0....100000000
                            100000..0...0..
                            .0.....1001000.
                            .0.1....0.0....
                            .10000000.0....
                            .0.0......0....
                            .0.0.....100...
                            ...0......0....
                            ..........0....";

            var words = new []
            {
                "sun",
                "sunglasses",
                "suncream",
                "swimming",
                "bikini",
                "beach",
                "icecream",
                "tan",
                "deckchair",
                "sand",
                "seaside",
                "sandals",
            };

            Solve(puzzle, words);
        }

        private static void Solve(string puzzle, IList<string> words)
        {
            var crossword = Crossword.FromDescription(puzzle);
            if(crossword.Solve(words))
            {
                Console.WriteLine("Solution");
                Console.WriteLine("--------");
                Console.WriteLine(crossword);
                Console.WriteLine();
            }
        }
    }
}
