public class Cell {
    private final boolean m_IsStartCell;
    private int m_WordsFromTheCell;
    private char m_CurrentChar;

    public Cell(int wordsFromTheCell) {
        m_IsStartCell = wordsFromTheCell > 0;
        m_WordsFromTheCell = wordsFromTheCell;
        m_CurrentChar = ' ';
    }

    public boolean isStartCell() {
        return m_IsStartCell;
    }

    public int wordsFromTheCell() {
        return m_WordsFromTheCell;
    }

    public char getCurrentChar() {
        return m_CurrentChar;
    }

    public void setCurrentChar(char c) {
        m_CurrentChar = c;
    }

    public void applyWordCountDelta(int delta) {
        m_WordsFromTheCell += delta;
    }

    @Override
    public String toString() {
        return Character.toString(m_CurrentChar);
    }
}
