using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossword
{
    internal class Crossword
    {
        private readonly Cell[,] m_Cells;

        private Crossword(Cell[,] cells)
        {
            m_Cells = cells;
            this.Rows = cells.GetUpperBound(0) + 1;
            this.Columns = cells.GetUpperBound(1) + 1;
        }

        public int Rows{get;}
        
        public int Columns{get;}

        public bool Solve(IList<string> words)
        {
            Cell cell = Cell.None;
            var row = 0;
            var column = 0;

            // Looks for a cell that we can put a word into
            for(; row < this.Rows; row++)
            {
                for(column = 0; column < this.Columns; column++)
                {
                    var possibleCell = m_Cells[row, column];
                    if(possibleCell != Cell.None && possibleCell.IsStartCell && possibleCell.WordsFromHere > 0)
                    {
                        cell = possibleCell;
                        break;
                    }
                }

                if(cell != Cell.None) break;
            }

            // If we couldn't find a cell that needs solving then we're done!
            if(cell == Cell.None) return true;

            if(CanGoRight(row, column))
            {
                var pattern = GetWordRight(row, column);
                for(int i = 0; i < words.Count; i++)
                {
                    var word = words[i];
                    if(word is not null && IsMatch(pattern, word))
                    {
                        words[i] = null;

                        SetWordRight(row, column, word, -1);
                        if(Solve(words))
                        {
                            return true;
                        }

                        // We didn't solve the crossword, so put things back and try again
                        SetWordRight(row, column, pattern, 1);
                        words[i] = word;
                    }
                }
            }

            if(CanGoDown(row, column))
            {
                var pattern = GetWordDown(row, column);
                for(int i = 0; i < words.Count; i++)
                {
                    var word = words[i];
                    if(word is not null && IsMatch(pattern, word))
                    {
                        words[i] = null;

                        SetWordDown(row, column, word, -1);
                        if(Solve(words))
                        {
                            return true;
                        }

                        // We didn't solve the crossword, so put things back and try again
                        SetWordDown(row, column, pattern, 1);
                        words[i] = word;
                    }
                }
            }

            return false;
        }

        private bool IsMatch(string wordFromCrossword, string candidate)
        {
            if(wordFromCrossword.Length != candidate.Length) return false;

            for(var i = 0; i < wordFromCrossword.Length; i++)
            {
                // A space means there's a gap in the crossword, which is a match
                if(wordFromCrossword[i] == ' ') continue;

                if(wordFromCrossword[i] != candidate[i]) return false;
            }

            return true;
        }

        /// <summary>
        /// Work out if we can put in a word in the specified cell, going right
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public bool CanGoRight(int row, int column)
        {
            if(column + 1 == this.Columns) return false;

            var cell = m_Cells[row, column + 1];
            return cell != Cell.None;
        }

        /// <summary>
        /// Work out if we can put in a word in the specified cell, going down
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public bool CanGoDown(int row, int column)
        {
            if(row + 1 == this.Rows) return false;

            var cell = m_Cells[row + 1, column];
            return cell != Cell.None;
        }

        /// <summary>
        /// Gets the word that starts at the specified cell and goes right
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        private string GetWordRight(int row, int column)
        {
            var b = new StringBuilder(this.Columns);

            for(var i = column; i < this.Columns; i++)
            {
                var cell = m_Cells[row, i];
                if(cell == Cell.None) break;

                b.Append(cell.Character);
            }

            return b.ToString();
        }

        /// <summary>
        /// Gets the word that starts at the specified cell and goes down
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        private string GetWordDown(int row, int column)
        {
            var b = new StringBuilder(this.Rows);

            for(var i = row; i < this.Rows; i++)
            {
                var cell = m_Cells[i, column];
                if(cell == Cell.None) break;

                b.Append(cell.Character);
            }

            return b.ToString();
        }

        /// <summary>
        /// Fills the crossword with the supplied word
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="word"></param>
        /// <param name="delta"></param>
        private void SetWordRight(int row, int column, string word, int delta)
        {
            var startCell = m_Cells[row, column];
            m_Cells[row, column] = startCell with {WordsFromHere = startCell.WordsFromHere + delta};

            for(var i = 0; i < word.Length; i++)
            {
                m_Cells[row, column + i] = m_Cells[row, column + i] with {Character = word[i]};
            }
        }

        /// <summary>
        /// Fills the crossword with the supplied word
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="word"></param>
        /// <param name="delta"></param>
        private void SetWordDown(int row, int column, string word, int delta)
        {
            var startCell = m_Cells[row, column];
            m_Cells[row, column] = startCell with {WordsFromHere = startCell.WordsFromHere + delta};

            for(var i = 0; i < word.Length; i++)
            {
                m_Cells[row + i, column] = m_Cells[row + i, column] with {Character = word[i]};
            }
        }

        private string Render(Func<Cell, string> renderer)
        {
            var b = new StringBuilder((this.Columns + 2) * this.Rows);

            for(var row = 0; row < this.Rows; row++)
            {
                for(var column = 0; column < this.Columns; column++)
                {
                    var cell = m_Cells[row, column];
                    var asString = renderer(cell);
                    b.Append(asString);
                }

                b.AppendLine();
            }

            return b.ToString();
        }

        public override string ToString()
        {
            return Render(cell => cell.ToString());
        }

        public string ToConsole()
        {
            return Render(cell => cell.ToConsole());
        }

        public static Crossword FromDescription(string description)
        {
            var lines = description.Split('\n')
                                   .Select(row => row.Trim())
                                   .ToArray();

            var rows = lines.Length;
            var columns = lines[0].Length;
            var cells = new Cell[rows, columns];

            for(var row = 0; row < rows; row++)
            {
                var line = lines[row];

                for(var column = 0; column < columns; column++)
                {
                    char c = line[column];
                    cells[row, column] = Cell.FromChar(c);
                }
            }

            return new(cells);
        }
    }
}
