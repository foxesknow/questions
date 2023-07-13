defmodule ListNode do
  @type t :: %__MODULE__{
          val: integer,
          next: ListNode.t() | nil
        }
  defstruct val: 0, next: nil
end

defmodule Solution do
  def merge_k_lists([]) do
    nil
  end

  def merge_k_lists([list]) do
    list
  end

  @spec merge_k_lists(lists :: [ListNode.t | nil]) :: ListNode.t | nil
  def merge_k_lists(lists) do
    [first | rest] = lists
    Enum.reduce(rest, first, fn e, acc -> merge_two_lists(e, acc) end)
  end

  @spec merge_two_lists(list1 :: ListNode.t | nil, list2 :: ListNode.t | nil) :: ListNode.t | nil
  defp merge_two_lists(list1, list2) when list1.val < list2.val  do
    %ListNode{val: list1.val, next: merge_two_lists(list1.next, list2)}
  end

  defp merge_two_lists(list1, list2) when list1.val >= list2.val do
    %ListNode{val: list2.val, next: merge_two_lists(list1, list2.next)}
  end

  defp merge_two_lists(list1, nil) do
    list1
  end

  defp merge_two_lists(nil, list2) do
    list2
  end
end

defmodule Tests do
  defp list_to_string(list) when list == nil do
    ""
  end

  defp list_to_string(list) when list == [] do
    ""
  end

  defp list_to_string(list) do
    "#{list.val} " <> list_to_string(list.next)
  end

  def example1 do
    list1 = %ListNode{val: 1, next: %ListNode{val: 10, next: %ListNode{val: 400}}}
    list2 = %ListNode{val: 2, next: %ListNode{val: 30, next: %ListNode{val: 500}}}
    list3 = %ListNode{val: 40, next: %ListNode{val: 70, next: %ListNode{val: 600}}}
    IO.puts(list_to_string(Solution.merge_k_lists([list1, list2, list3])))
  end

  def example2 do
    IO.puts(list_to_string(Solution.merge_k_lists([])))
  end
end

Tests.example1
Tests.example2