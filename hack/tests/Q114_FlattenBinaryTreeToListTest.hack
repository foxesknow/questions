use function Facebook\FBExpect\expect;
use type Facebook\HackTest\{DataProvider, HackTest};

class Q114_FlattenBinaryTreeToListTest extends HackTest {
  public function testExample1(): void {
    $s = new LeetCode\Q114\Solution();
    $node = TreeNode::makeTree(1,2,5,3,4,null,6);
    $s->flatten($node);

    expect($node->left)->toBeNull();
    expect($node->val)->toEqual(1);

    $right = expect($node->right)->toNotBeNull();
    expect($right->left)->toBeNull();
    expect($right->val)->toEqual(2);

    $right = expect($right->right)->toNotBeNull();
    expect($right->left)->toBeNull();
    expect($right->val)->toEqual(3);

    $right = expect($right->right)->toNotBeNull();
    expect($right->left)->toBeNull();
    expect($right->val)->toEqual(4);

    $right = expect($right->right)->toNotBeNull();
    expect($right->left)->toBeNull();
    expect($right->val)->toEqual(5);

    $right = expect($right->right)->toNotBeNull();
    expect($right->left)->toBeNull();
    expect($right->right)->toBeNull();
    expect($right->val)->toEqual(6);
  }
}