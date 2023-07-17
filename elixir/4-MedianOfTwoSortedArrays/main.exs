defmodule Solution do
  @spec find_median_sorted_arrays(nums1 :: [integer], nums2 :: [integer]) :: float
  def find_median_sorted_arrays(nums1, nums2) do
    # Work out how many items we have to ignore before we get the median
    total_length = length(nums1) + length(nums2)
    mid = ceil(total_length / 2) - 1
    {left, right} = Enum.reduce(1..mid//1, {nums1, nums2}, fn _, {l, r} -> advance_one(l, r) end)

    if rem(total_length, 2) == 1 do
      next({left, right})
    else
      first_value = next({left, right})
      second_value = advance_one(left, right) |> next()

      (first_value + second_value) / 2
    end

  end

  defp advance_one([], []) do
  end

  defp advance_one([_ | t1], []) do
    {t1, []}
  end

  defp advance_one([], [_ | t2]) do
    {[], t2}
  end

  defp advance_one([h1 | t1] = nums1, [h2 | t2] = nums2) do
    if h1 < h2 do
      {t1, nums2}
    else
      {nums1, t2}
    end
  end

  defp next({nums1, nums2}) do
    case {nums1, nums2} do
      {[h1 | _], []} -> h1
      {[], [h2 | _]} -> h2
      {[h1 | _], [h2 | _]} -> min(h1, h2)
    end
  end
end

IO.inspect(Solution.find_median_sorted_arrays([1,2], [3,4]))
IO.inspect(Solution.find_median_sorted_arrays([1,2], [3]))
IO.inspect(Solution.find_median_sorted_arrays([], [1,2]))