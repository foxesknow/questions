using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossword
{
    internal record struct Cell
    {
        public static readonly Cell None = new();

        public Cell(int wordsFromHere)
        {
            this.WordsFromHere = wordsFromHere;
        }

        public int WordsFromHere{get; init;}

        public char Character{get; init;} = ' ';

        public bool IsStartCell
        {
            get{return this.WordsFromHere > 0;}
        }

        public override string ToString()
        {
            if(this.Character == '\0') return ".";
            
            return this.Character.ToString();
        }

        public static Cell FromChar(char c)
        {
            if(c == '.') return Cell.None;

            var wordCount = c - '0';
            return new(wordCount);
        }
    }
}
