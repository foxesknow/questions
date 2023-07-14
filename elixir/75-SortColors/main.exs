defmodule Solution do
  @spec sort_colors(colors :: [integer]) :: [integer]
  def sort_colors(colors) do
    {red, white, blue} = count(colors, 0, 0, 0)
    flatten(red, white, blue, [])
  end

  def flatten(0, 0, 0, acc) do
    acc
  end

  def flatten(red, white, blue, acc) do
    cond do
      blue > 0  -> flatten(red, white, blue - 1, [2 | acc])
      white > 0 -> flatten(red, white - 1, blue, [1 | acc])
      true      -> flatten(red - 1, white, blue, [0 | acc])
    end
  end

  defp count([], red, white, blue) do
    {red, white, blue}
  end

  defp count([color | rest], red, white, blue) do
    cond do
      color == 0  -> count(rest, red + 1, white, blue)
      color == 1  -> count(rest, red, white + 1, blue)
      true        -> count(rest, red, white, blue + 1)
    end
  end
end

IO.inspect(Solution.sort_colors([2,0,2,1,1,0]))
IO.inspect(Solution.sort_colors([2,0,1]))