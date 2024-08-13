namespace LeetCode\Q20;

use namespace HH\Lib\C;
use namespace HH\Lib\Str;

class Solution {
  public function isValid(string $s): bool {
      $stack = vec[];

      for ($i = 0; $i < Str\length($s); $i++) {
        $c = $s[$i];

        if ($c == "(" || $c == "{" || $c == "[") {
          $stack[] = $c;
          continue;
        }

        if (!$stack) return false;

        $top = C\pop_back(inout $stack);

        $isValid = false;
        if ($top == "(" && $c == ")") $isValid = true;
        else if ($top == "[" && $c == "]") $isValid = true;
        else if ($top == "{" && $c == "}") $isValid = true;

        if (!$isValid) return false;
      }

      return C\count($stack) == 0;
  }
}