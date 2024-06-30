use function Facebook\FBExpect\expect;
use type Facebook\HackTest\{DataProvider, HackTest};

class Q110_BalancedTreeTest extends HackTest {
  public function testExample10():void {
    $s = new LeetCode\Q110\Solution();

    $root = new TreeNode(1);
    expect($s->isBalanced($root))->toBeTrue();
  }

  public function testExample11():void {
    $s = new LeetCode\Q110\Solution();

    $root = new TreeNode(1, new TreeNode(2));
    expect($s->isBalanced($root))->toBeTrue();
  }

  public function testExample12():void {
    $s = new LeetCode\Q110\Solution();

    $root = new TreeNode(1, new TreeNode(2, new TreeNode(3)));
    expect($s->isBalanced($root))->toBeFalse();
  }
}