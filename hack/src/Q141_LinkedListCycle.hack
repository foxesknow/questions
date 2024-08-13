namespace LeetCode\Q141;

class Solution {
  public function hasCycle(?\ListNode $head): bool {
    if ($head is null || $head->next is null) return false;

    $slow = $head;
    $fast = $head->next;

    while (true) {
      if ($slow is null || $fast is null) return false;
      if ($slow === $fast) break;

      $slow = $slow->next;
      $fast = $fast->next?->next;
    }

    return true;
  }
}