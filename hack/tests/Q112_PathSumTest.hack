use function Facebook\FBExpect\expect;
use type Facebook\HackTest\{DataProvider, HackTest};

class Q112_PathSumTest extends HackTest {
  public function testExample1(): void {
    $s = new LeetCode\Q112\Solution();

    $root = TreeNode::makeTree(5,4,8,11,null,13,4,7,2,null,null,null,1);
    expect($s->hasPathSum($root, 22))->toBeTrue();
  }

  public function testExample2(): void {
    $s = new LeetCode\Q112\Solution();

    $root = TreeNode::makeTree(1, 2, 3);
    expect($s->hasPathSum($root, 5))->toBeFalse();
  }
}