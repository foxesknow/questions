namespace LeetCode\Q114;

class Solution2 {
  /*
  * To flatten the list we just need to walk the tree in right-left-node order
  * maintaining a a tail we'll append to (ala cons)
  */
  public function flatten(?\TreeNode $node): void {
    if ($node is null) return;

    $this->walk($node, null);
  }

  private function walk(?\TreeNode $node, ?\TreeNode $tail): ?\TreeNode {
    if ($node is null) return $tail;

    $tail = $this->walk($node->right, $tail);
    $tail = $this->walk($node->left, $tail);

    $node->left = null;
    $node->right = $tail;

    return $node;
  }
}
