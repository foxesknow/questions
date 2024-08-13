use namespace HH\Lib\C;

class ListNode {
  public int $val = 0;
  public ?ListNode $next = null;

  public function __construct(int $val, ?ListNode $next = null) {
    $this->val = $val;
    $this->next = $next;
  }

  public static function requireNext(inout ListNode $node): ListNode {
    invariant($node->next != null, "no next on node");
    $node = $node->next;
    return $node;
  }

  public static function print(?ListNode $node): void {
    while ($node != null) {
      echo $node->val . " ";
      $node = $node->next;
    }

    echo "\n";
  }

  public static function makeList(int ...$values): ?ListNode {
    $head = null;

    for ($i = C\count($values) - 1; $i >= 0; $i--) {
      $value= $values[$i];
      $node = new ListNode($value, $head);
      $head = $node;
    }

    return $head;
  }
}
