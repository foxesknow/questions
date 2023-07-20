defmodule Solution do
  @spec two_sum(nums :: [integer], target :: integer) :: [integer]
  def two_sum(nums, target) do
    find(%{}, target, 0, nums)
  end

  defp find(_map, _target, _index, []) do
    -1
  end

  defp find(map, target, index, [number | rest]) do
    case Map.get(map, target - number, -1) do
      -1    -> Map.put(map, number, index) |> find(target, index + 1, rest)
      value -> [index, value]
    end
  end
end

IO.inspect(Solution.two_sum([2,7,11,15], 9))
IO.inspect(Solution.two_sum([3,2,4], 6))
IO.inspect(Solution.two_sum([3,3], 6))
IO.inspect(Solution.two_sum([1,3,7,9,21,15], 24))