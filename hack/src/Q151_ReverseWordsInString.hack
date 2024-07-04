namespace LeetCode\Q151;

use namespace HH\Lib\{Str, Vec};

class Solution {
  public function reverseWords(string $s): string {
    return  Str\split($s, " ")
            |> Vec\filter($$, $word ==> $word !== "")
            |> Vec\reverse($$)
            |> Str\join($$, " ");
  }
}