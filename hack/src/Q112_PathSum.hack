namespace LeetCode\Q112;

class Solution {
  public function hasPathSum(?\TreeNode $root, int $target): bool {
    if (!$root) return false;

    // If we're at a leaf and the target is zero then we're done!
    if ($root->left is null && $root->right is null && $target - $root->val == 0) return true;

    if ($root->left && $this->hasPathSum($root->left, $target - $root->val)) return true;

    if ($root->right && $this->hasPathSum($root->right, $target - $root->val)) return true;

    return false;
  }
}