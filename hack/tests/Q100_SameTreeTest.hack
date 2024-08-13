use function Facebook\FBExpect\expect;
use type Facebook\HackTest\{DataProvider, HackTest};

class Q100_SameTreeTest extends HackTest {
  public function testExample1(): void {
    $s = new LeetCode\Q100\Solution();
    $p = new TreeNode(1, new TreeNode(2), new TreeNode(3));
    $q = new TreeNode(1, new TreeNode(2), new TreeNode(3));
    expect($s->isSameTree($p, $q))->toBeTrue();
  }

  public function testExample2(): void {
    $s = new LeetCode\Q100\Solution();
    $p = new TreeNode(1, new TreeNode(2));
    $q = new TreeNode(1, null, new TreeNode(3));
    expect($s->isSameTree($p, $q))->toBeFalse();
  }

  public function testExample3(): void {
    $s = new LeetCode\Q100\Solution();
    $p = new TreeNode(1, new TreeNode(2), new TreeNode(1));
    $q = new TreeNode(1, new TreeNode(1), new TreeNode(2));
    expect($s->isSameTree($p, $q))->toBeFalse();
  }
}
