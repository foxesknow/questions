use function Facebook\FBExpect\expect;
use type Facebook\HackTest\{DataProvider, HackTest};

class Q151_ReverseWordsInStringTest extends HackTest {
  public function testExample1(): void {
    $s = new LeetCode\Q151\Solution();
    $words = "the sky is blue";

    expect($s->reverseWords($words))->toEqual("blue is sky the");
  }

  public function testExample2(): void {
    $s = new LeetCode\Q151\Solution();
    $words = "  hello world  ";

    expect($s->reverseWords($words))->toEqual("world hello");
  }

  public function testExample3(): void {
    $s = new LeetCode\Q151\Solution();
    $words = "a good   example";

    expect($s->reverseWords($words))->toEqual("example good a");
  }
}