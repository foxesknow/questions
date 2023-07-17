defmodule Solution do
  @spec find_duplicates(nums :: [integer]) :: [integer]
  def find_duplicates(nums) do
    nums
    |> Enum.frequencies()
    |> Stream.filter(fn {_, freq} -> freq == 2 end)
    |> Stream.map(fn {num, _} -> num end)
    |> Enum.to_list()
  end
end

IO.inspect(Solution.find_duplicates([4,3,2,7,8,2,3,1]))
IO.inspect(Solution.find_duplicates([1,1,2]))
IO.inspect(Solution.find_duplicates([]))