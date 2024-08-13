use function Facebook\FBExpect\expect;
use type Facebook\HackTest\{DataProvider, HackTest};

class Q14_LongestCommonPrefixTest extends HackTest {
  public function testExample1(): void {
    $solution = new LeetCode\Q14\Solution();
    $prefix = $solution->longestCommonPrefix(vec["flower", "flow", "flight"]);
    expect($prefix)->toBeSame("fl");
  }

  public function testExample2(): void {
    $solution = new LeetCode\Q14\Solution();
    $prefix = $solution->longestCommonPrefix(vec["dog", "racecar", "car"]);
    expect($prefix)->toBeSame("");
  }
}