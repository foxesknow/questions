function swapPairs(?ListNode $head): ?ListNode {
  if ($head == null || $head->next == null) return $head;

  $swapHead = null;
  $tail = null;

  while ($head) {
    if ($head->next is null) {
      if ($swapHead is null) {
        $swapHead = $head;
      } else {
        ($tail as nonnull)->next = $head;
      }

      $head = $head->next;
    } else {
      // We've got at least 2 items
      $newHead = $head->next->next;
      $swap = $head->next;
      $swap->next = $head;
      ($swap->next as nonnull)->next = null;

      if ($swapHead is null) {
        $swapHead = $swap;
      } else {
        ($tail as nonnull)->next = $swap;
      }

      $tail = $swap->next;
      $head = $newHead;
    }
  }

  return $swapHead;
}