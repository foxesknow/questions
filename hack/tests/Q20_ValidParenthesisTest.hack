use function Facebook\FBExpect\expect;
use type Facebook\HackTest\{DataProvider, HackTest};

final class Q20_ValidParenthesisTest extends HackTest {
  public function generateTestData(): vec<(string, bool)> {
    return vec [
      tuple("()", true),
      tuple("()[]{}", true),
      tuple("(}", false),
    ];
  }

  <<DataProvider('generateTestData')>>
  public function testExample1(string $expression, bool $expected): void {
    $solution = new LeetCode\Q20\Solution();
    $isValid = $solution->isValid($expression);
    expect($isValid)->toBeSame($expected);
  }
}