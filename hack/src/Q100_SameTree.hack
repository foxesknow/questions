namespace LeetCode\Q100;

use namespace HH\Lib\C;
use namespace HH\Lib\Vec;

class Solution {
  public function isSameTree(?\TreeNode $p, ?\TreeNode $q): bool {
    $stack = vec[];
    $stack[] = tuple($p, $q);

    while (C\count($stack)) {
      list($left, $right) = (C\pop_back(inout $stack) as nonnull);

      if ($left == null && $right == null) continue;
      if ($left == null || $right == null) return false;

      if ($left->val != $right->val) return false;

      $stack[]= tuple($left->left, $right->left);
      $stack[]= tuple($left->right, $right->right);
    }

    return true;
  }
}