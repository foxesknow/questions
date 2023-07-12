defmodule Solution do
  @spec offset(previous :: String.t, c :: String.t) :: integer
  defp offset(last, c) do
    case {c, last} do
      {"I", _} -> 1
      {"V", "I"} -> 3
      {"V", _} -> 5
      {"X", "I"} -> 8
      {"X", _} -> 10
      {"L", "X"} -> 30
      {"L", _} -> 50
      {"C", "X"} -> 80
      {"C", _} -> 100
      {"D", "C"} -> 300
      {"D", _} -> 500
      {"M", "C"} -> 800
      {"M", _} -> 1000
      _ -> 0
    end
  end

  defp execute(last, rest, acc) do
    if rest == [] do
        acc
    else
        [c | next] = rest
        execute(c, next, acc + offset(last, c)) 
    end
  end

  @spec roman_to_int(s :: String.t) :: integer
  def roman_to_int(s) do
    execute(" ", String.graphemes(s), 0)
  end
end

IO.puts(Solution.roman_to_int("III"))
IO.puts(Solution.roman_to_int("LVIII"))
IO.puts(Solution.roman_to_int("MCMXCIV"))