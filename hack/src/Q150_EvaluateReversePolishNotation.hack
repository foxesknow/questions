namespace LeetCode\Q150;

use namespace HH\Lib\C;
use namespace HH\Lib\Str;

class Solution {
  public function evalRPN(vec<string> $tokens): int {
    $stack = vec[];

    foreach ($tokens as $token) {
      if ($token === "+") {
        $rhs = $this->pop(inout $stack);
        $lhs = $this->pop(inout $stack);
        $stack[] = $lhs + $rhs;
      } else if ($token === "-") {
        $rhs = $this->pop(inout $stack);
        $lhs = $this->pop(inout $stack);
        $stack[] = $lhs - $rhs;
      } else if ($token === "*") {
        $rhs = $this->pop(inout $stack);
        $lhs = $this->pop(inout $stack);
        $stack[] = $lhs * $rhs;
      } else if ($token === "/") {
        $rhs = $this->pop(inout $stack);
        $lhs = $this->pop(inout $stack);
        $stack[] = (int)($lhs / $rhs);
      } else {
        $value = Str\to_int($token) as nonnull;
        $stack[] = $value;
      }
    }

    return C\pop_back(inout $stack) as nonnull;
  }

  private function pop(inout vec<int> $stack): int {
    return C\pop_back(inout $stack) as nonnull;
  }
}