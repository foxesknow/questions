use function Facebook\FBExpect\expect;
use type Facebook\HackTest\{DataProvider, HackTest};

final class Q13_RomanToIntegerTest extends HackTest {
    public function testExample1(): void {
        $result = roman_to_int("III");
        expect($result)->toBeSame(3);
    }

    public function testExample2(): void {
        $result = roman_to_int("LVIII");
        expect($result)->toBeSame(58);
    }

    public function testExample3(): void {
        $result = roman_to_int("MCMXCIV");
        expect($result)->toBeSame(1994);
    }
}