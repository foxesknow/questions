use namespace HH\Lib\C;

class TreeNode {
  public int $val = 0;
  public ?TreeNode $left = null;
  public ?TreeNode $right = null;

  public function __construct(int $val, ?TreeNode $left = null, ?TreeNode $right = null) {
    $this->val = $val;
    $this->left = $left;
    $this->right = $right;
  }

  public static function makeTree(int $rootValue, ?int ...$vals): TreeNode {
    $root = new TreeNode($rootValue);
    $queue = vec[$root];

    for ($i = 0; $i < C\count($vals); $i += 2) {
      $node = C\pop_front(inout $queue);

      $leftVal = $vals[$i];
      if ($leftVal && $node)
      {
        $leftNode = new TreeNode($leftVal);
        $node->left = $leftNode;
        $queue[] = $leftNode;
      } else {
        $queue[] = null;
      }

      $rightVal = $vals[$i + 1];
      if ($rightVal && $node)
      {
        $rightNode = new TreeNode($rightVal);
        $node->right = $rightNode;
        $queue[] = $rightNode;
      } else {
        $queue[] = null;
      }
    }

    return $root;
  }
} 
