namespace LeetCode\Q26;

use namespace HH\Lib\C;

class Solution {
  public function removeDuplicates(inout vec<int> $nums): int {
    $currentValue = $nums[0];
    $insertionPoint = 1;

    for ($i = 1; $i < C\count($nums); $i++) {
      $value = $nums[$i];

      if ($value != $currentValue) {
        $nums[$insertionPoint] = $value;
        $insertionPoint++;
        $currentValue = $value;
      }
    }

    return $insertionPoint;
  }
}