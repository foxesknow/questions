class TreeNode {
  public int $val = 0;
  public ?TreeNode $left = null;
  public ?TreeNode $right = null;

  public function __construct(int $val, ?TreeNode $left = null, ?TreeNode $right = null) {
    $this->val = $val;
    $this->left = $left;
    $this->right = $right;
  }
} 
