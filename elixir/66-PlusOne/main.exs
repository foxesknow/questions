defmodule Solution do
  @spec plus_one(digits :: [integer]) :: [integer]
  def plus_one(digits) do
    {carry, s} = add(digits)

    if carry == 1 do
      [1 | s]
    else
      s
    end
  end

  defp add([digit]) do
    value = digit + 1
    {div(value, 10), [rem(value, 10)]}
  end

  defp add([digit | rest]) do
    {carry, s} = add(rest)
    {div(digit + carry, 10), [rem(digit + carry, 10) | s]}
  end
end

defmodule Tests do
  def example1 do
    IO.inspect(Solution.plus_one([1, 2, 3]))
  end

  def example2 do
    IO.inspect(Solution.plus_one([4, 3, 2, 1]))
  end

  def example3 do
    IO.inspect(Solution.plus_one([9]))
  end

  def example4 do
    IO.inspect(Solution.plus_one([9, 9]))
  end
end

Tests.example1
Tests.example2
Tests.example3
Tests.example4