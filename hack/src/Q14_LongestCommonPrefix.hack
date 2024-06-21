namespace LeetCode\Q14;

use namespace HH\Lib\Vec;
use namespace HH\Lib\C;
use namespace HH\Lib\Math;
use namespace HH\Lib\Str;

class Solution {
  public function longestCommonPrefix(vec<string> $strs): string {
    if (C\count($strs) == 1) return $strs[0];
    
    $sorted = Vec\sort($strs);
    $first = $strs[0];
    $last = $strs[C\count($strs) - 1];
    $range = Math\maxva(Str\length($first), Str\length($last));

    for ($i = 0; $i < $range; $i++) {
      if ($first[$i] != $last[$i]) {
        return Str\slice($first, 0, $i);
      }
    }

    return $first;
  }
}