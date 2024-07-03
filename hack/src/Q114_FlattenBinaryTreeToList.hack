namespace LeetCode\Q114;

class Solution {
  public function flatten(?\TreeNode $node): void {
    if ($node is null) return;

    $head = null;
    $next = null;

    foreach($this->walk($node) as $n) {
      if ($head) {
        ($next as nonnull)->right = $n;
        $next = ($next as nonnull)->right;
      } else {
        $head = $n;
        $next = $n;
      }
    }
  }

  private function walk(?\TreeNode $node): \Generator<int, \TreeNode, void> {
    if ($node) {
      $left = $node->left;
      $right = $node->right;

      $node->left = null;
      $node->right = null;

      yield $node;

      foreach($this->walk($left) as $l) {
        yield $l;
      }

      foreach($this->walk($right) as $r) {
        yield $r;
      }
    }
  }
}