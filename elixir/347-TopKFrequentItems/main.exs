defmodule Solution do
  @spec top_k_frequent(nums :: [integer], k :: integer) :: [integer]
  def top_k_frequent(nums, k) do
    nums 
    |> Enum.frequencies() 
    |> Enum.sort(fn {_, x}, {_, y} -> x > y end) 
    |> Enum.take(k)
    |> Enum.map(fn {n, _} -> n end)
  end
end

IO.inspect(Solution.top_k_frequent([1,1,1,2,2,3], 2))
IO.inspect(Solution.top_k_frequent([1], 1))