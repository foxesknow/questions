namespace LeetCode\Q50;

class Solution {
  public function myPow(float $x, int $n): float {
    if ($x == 1 || $n == 0) return 1.0;
    if ($n == 1) return $x;
    if ($n == -1) return 1 / $x;
    if ($x == 0) return 0.0;

    $half = $this->myPow($x, (int)($n / 2));
    $value = $half * $half;

    if (($n & 1) == 1) {
      $sign = ($n >= 0 ? 1 : -1);
      return $value * $this->myPow($x, $sign);
    } else {
      return $value;
    }
  }
}