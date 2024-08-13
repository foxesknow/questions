function mergeTwoLists(?ListNode $list1, ?ListNode $list2): ?ListNode {
  if ($list1 == null) return $list2;
  if ($list2 == null) return $list1;

  $next = (inout ?ListNode $list1, inout ?ListNode $list2) ==> {
    invariant($list1 != null, "list1 is null");
    invariant($list2 != null, "list2 is null");

    if ($list1->val < $list2->val) {
      $node = $list1;
      $list1 = $list1->next;

      return $node;
    } else {
      $node = $list2;
      $list2 = $list2->next;

      return $node;
    }
  };

  $head = $next(inout $list1, inout $list2);
  $tail = $head;

  while ($list1 != null && $list2 != null) {
    $smallest = $next(inout $list1, inout $list2);
    $tail->next = $smallest;
    $tail = $smallest;
  }

  $tail->next = ($list1 != null ? $list1 : $list2);

  return $head;
}