use function Facebook\FBExpect\expect;
use type Facebook\HackTest\{DataProvider, HackTest};

class Q150_EvaluateReversePolishNotationTest extends HackTest {
  public function testExample1(): void {
    $s = new LeetCode\Q150\Solution();
    $tokens = vec["2","1","+","3","*"];

    expect($s->evalRPN($tokens))->toEqual(9);
  }

  public function testExample2(): void {
    $s = new LeetCode\Q150\Solution();
    $tokens = vec["4","13","5","/","+"];

    expect($s->evalRPN($tokens))->toEqual(6);
  }

  public function testExample3(): void {
    $s = new LeetCode\Q150\Solution();
    $tokens = vec["10","6","9","3","+","-11","*","/","*","17","+","5","+"];

    expect($s->evalRPN($tokens))->toEqual(22);
  }
}