import java.util.*;

public class Main {
    public static void main(String[] args) {
        doWords();
        doFood();
        doHolidays();
        System.out.println("done");
    }

    static void doWords() {
        String puzzle = "2001\n0..0\n1000\n0..0";
        String[] words = new String[] { "casa", "alan", "ciao", "anta" };

        var crossword = Crossword.fromDescription(puzzle);
        crossword.solve(Arrays.asList(words));

        System.out.println("Solution");
        System.out.println(crossword);
        System.out.println();
    }

    static void doFood() {
        String puzzle = """
                ..1.1..1...
                10000..1000
                ..0.0..0...
                ..1000000..
                ..0.0..0...
                1000..10000
                ..0.1..0...
                ....0..0...
                ..100000...
                ....0..0...
                ....0......""";

        String[] words = new String[] {
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

        var crossword = Crossword.fromDescription(puzzle);
        crossword.solve(Arrays.asList(words));

        System.out.println("Solution");
        System.out.println(crossword);
        System.out.println();
    }

    static void doHolidays() {
        String puzzle = """
                ...1...........
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
                ..........0....""";

        String[] words = new String[] {
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

        var crossword = Crossword.fromDescription(puzzle);
        crossword.solve(Arrays.asList(words));

        System.out.println("Solution");
        System.out.println(crossword);
        System.out.println();
    }
}