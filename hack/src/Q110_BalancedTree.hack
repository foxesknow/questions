namespace LeetCode\Q110;

use namespace HH\Lib\Math;

class Solution {
  public function isBalanced(\TreeNode $root): bool {
    $isBalanced = true;
    $this->depth($root, 0, inout $isBalanced);

    return $isBalanced;
  }

  private function depth(?\TreeNode $node, int $acc, inout bool $isBalanced): int {
    if ($node is null || !$isBalanced) return $acc;

    $leftDepth = $this->depth($node->left, $acc + 1, inout $isBalanced);
    $rightDepth = $this->depth($node->right, $acc + 1, inout $isBalanced);

    if (Math\abs($leftDepth - $rightDepth) > 1) $isBalanced = false;

    return Math\maxva($leftDepth, $rightDepth);
  }
}