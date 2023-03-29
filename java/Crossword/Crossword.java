import java.util.*;

public class Crossword {
    private final Cell[][] m_Board;
    private final int m_RowCount;
    private final int m_ColumnCount;

    private Crossword(Cell[][] board) {
        m_Board = board;
        m_RowCount = board.length;
        m_ColumnCount = board[0].length;
    }

    public int getRowCount() {
        return m_RowCount;
    }

    public int getColumnCount() {
        return m_ColumnCount;
    }

    public boolean solve(List<String> words) {
        Cell cell = null;
        var row = 0;
        var column = 0;

        // Look for a cell that we can try to place a word into
        for (; row < m_RowCount; row++) {
            for (column = 0; column < m_ColumnCount; column++) {
                var possibleCell = m_Board[row][column];

                if (possibleCell != null && possibleCell.isStartCell() && possibleCell.wordsFromTheCell() > 0) {
                    cell = possibleCell;
                    break;
                }
            }

            if (cell != null) {
                break;
            }
        }

        if (cell == null) {
            // There are no more cells left to solve
            return true;
        }

        if (canGoRight(row, column)) {
            // Get the current word at [row, col] and to the right.
            // It may just be spaces, or it may have some letters in from words that
            // intersect it.
            var pattern = getWordRight(row, column);

            // Find a word that matches the pattern
            for (var i = 0; i < words.size(); i++) {
                var word = words.get(i);

                // If the word is null it means we've previously checked it out
                if (word != null && isMatch(pattern, word)) {
                    words.set(i, null);

                    // Add the word to the crossword and try to solve it
                    setWordRight(row, column, word, -1);
                    if (solve(words)) {
                        return true;
                    }

                    // We didn't solve it with this word. Put it back and try another
                    setWordRight(row, column, pattern, 1);
                    words.set(i, word);
                }
            }
        }

        if (canGoDown(row, column)) {
            // Get the current word at [row, col] and to the right.
            // It may just be spaces, or it may have some letters in from words that
            // intersect it.
            var pattern = getWordDown(row, column);

            // Find a word that matches the pattern
            for (var i = 0; i < words.size(); i++) {
                var word = words.get(i);

                // If the word is null it means we've previously checked it out
                if (word != null && isMatch(pattern, word)) {
                    words.set(i, null);

                    // Add the word to the crossword and try to solve it
                    setWordDown(row, column, word, -1);
                    if (solve(words)) {
                        return true;
                    }

                    // We didn't solve it with this word. Put it back and try another
                    setWordDown(row, column, pattern, 1);
                    words.set(i, word);
                }
            }
        }

        return false;
    }

    private boolean isMatch(String wordFromCrossword, String candidate) {
        if (wordFromCrossword.length() != candidate.length()) {
            return false;
        }

        for (var i = 0; i < wordFromCrossword.length(); i++) {
            if (wordFromCrossword.charAt(i) == ' ') {
                continue;
            }

            if (wordFromCrossword.charAt(i) != candidate.charAt(i)) {
                return false;
            }
        }

        return true;
    }

    private boolean canGoRight(int row, int column) {
        if (column + 1 == m_ColumnCount) {
            return false;
        }

        var cell = m_Board[row][column + 1];
        return cell != null;
    }

    private boolean canGoDown(int row, int column) {
        if (row + 1 == m_RowCount) {
            return false;
        }

        var cell = m_Board[row + 1][column];
        return cell != null;
    }

    private String getWordRight(int row, int column) {
        String word = "";

        for (int i = column; i < m_ColumnCount; i++) {
            var cell = m_Board[row][i];

            if (cell == null) {
                break;
            }

            word += cell.getCurrentChar();
        }

        return word;
    }

    private String getWordDown(int row, int column) {
        String word = "";

        for (int i = row; i < m_RowCount; i++) {
            var cell = m_Board[i][column];

            if (cell == null) {
                break;
            }

            word += cell.getCurrentChar();
        }

        return word;
    }

    private void setWordRight(int row, int column, String word, int delta) {
        var startCell = m_Board[row][column];
        startCell.applyWordCountDelta(delta);

        for (int i = 0; i < word.length(); i++) {
            var c = word.charAt(i);

            var cell = m_Board[row][column + i];
            cell.setCurrentChar(c);
        }
    }

    private void setWordDown(int row, int column, String word, int delta) {
        var startCell = m_Board[row][column];
        startCell.applyWordCountDelta(delta);

        for (int i = 0; i < word.length(); i++) {
            var c = word.charAt(i);

            var cell = m_Board[row + i][column];
            cell.setCurrentChar(c);
        }
    }

    public static Crossword fromDescription(String description) {
        var board = description.lines()
                .map(Crossword::stringToRow)
                .toArray(Cell[][]::new);

        return new Crossword(board);
    }

    @Override
    public String toString() {
        var b = new StringBuilder();

        for (var row = 0; row < m_RowCount; row++) {
            for (var column = 0; column < m_ColumnCount; column++) {
                var cell = m_Board[row][column];
                var c = (cell == null ? '.' : cell.getCurrentChar());
                b.append(c);
            }

            b.append(System.lineSeparator());
        }
        return b.toString();
    }

    private static Cell[] stringToRow(String s) {
        var row = new Cell[s.length()];

        for (int i = 0; i < row.length; i++) {
            Cell cell = null;

            var c = s.charAt(i);
            if (c != '.') {
                var wordsFromThisCell = c - '0';
                cell = new Cell(wordsFromThisCell);
            }

            row[i] = cell;
        }

        return row;
    }
}
