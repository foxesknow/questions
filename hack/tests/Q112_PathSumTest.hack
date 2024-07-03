use function Facebook\FBExpect\expect;
use type Facebook\HackTest\{DataProvider, HackTest};

class Q112_PathSumTest extends HackTest {
  public function testExample1(): void {
    $s = new LeetCode\Q112\Solution();

    $root = new TreeNode(5,
                         new TreeNode(4,
                                      new TreeNode(11,
                                                   new TreeNode(7),
                                                   new TreeNode(2))),
                                                   
                          new TreeNode(8,
                                      new TreeNode(13),
                                      new TreeNode(4,
                                                   null,
                                                   new TreeNode(1)))
                        );

      expect($s->hasPathSum($root, 22))->toBeTrue();
  }

  public function testExample2(): void {
    $s = new LeetCode\Q112\Solution();

    $root = new TreeNode(1, new TreeNode(2), new TreeNode(3));
    expect($s->hasPathSum($root, 5))->toBeFalse();
  }
}