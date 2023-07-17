defmodule Solution do
  @spec check_perfect_number(num :: integer) :: boolean
  def check_perfect_number(num) do
    upper = floor(:math.sqrt(num))

    nums = for x <- 2..upper, rem(num, x) == 0, do: [x, div(num, x)]
    total = [[1] | nums]
            |> Enum.flat_map(fn x -> x end)
            |> Enum.reduce(fn n, acc -> n + acc end)
    total == num
  end
end

IO.inspect(Solution.check_perfect_number(28))
IO.inspect(Solution.check_perfect_number(7))