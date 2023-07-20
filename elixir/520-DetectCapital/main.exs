defmodule Solution do
  @spec detect_capital_use(word :: String.t) :: boolean
  def detect_capital_use(word) do
    word == String.downcase(word) or 
    word == String.upcase(word) or
    word == String.capitalize(word)
  end
end

IO.puts(Solution.detect_capital_use("USA"))
IO.puts(Solution.detect_capital_use("leetcode"))
IO.puts(Solution.detect_capital_use("Google"))
IO.puts(Solution.detect_capital_use("FLaG"))