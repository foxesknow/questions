defmodule Solution do
  @spec letter_combinations(digits :: String.t) :: [String.t]
  def letter_combinations(digits) do
    if digits == "" do
      []
    else
      buttons = %{
        "2" => ["a", "b", "c"],
        "3" => ["d", "e", "f"],
        "4" => ["g", "h", "i"],
        "5" => ["j", "k", "l"],
        "6" => ["m", "n", "o"],
        "7" => ["p", "q", "r", "s"],
        "8" => ["t", "u", "v"],
        "9" => ["w", "x", "y", "z"],
      }

      recurse(String.graphemes(digits), buttons, "")
    end
  end

  defp recurse(digits, _, current) when digits == [] do
    [current]
  end

  defp recurse(digits, buttons, current) when digits != nil do
    [digit | digits] = digits
    letters = buttons[digit]

    Enum.flat_map(letters, fn l -> recurse(digits, buttons, current <> l) end)
  end
end

defmodule Tests do
  defp list_to_string(list) when list == [] do
    ""
  end

  defp list_to_string([head | tail]) do
    "[#{head}] " <> list_to_string(tail)
  end

  def example1 do
    IO.puts(list_to_string(Solution.letter_combinations("23")))
  end

  def example2 do
    IO.puts(list_to_string(Solution.letter_combinations("2")))
  end
  def example3 do
    IO.puts(list_to_string(Solution.letter_combinations("357")))
  end
end

Tests.example1
Tests.example2
Tests.example3