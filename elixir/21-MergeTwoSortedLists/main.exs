defmodule ListNode do
  @type t :: %__MODULE__{
          val: integer,
          next: ListNode.t() | nil
        }
  defstruct val: 0, next: nil
end

defmodule Solution do
  @spec merge_two_lists(list1 :: ListNode.t | nil, list2 :: ListNode.t | nil) :: ListNode.t | nil
  def merge_two_lists(list1, list2) when list1.val < list2.val  do
    %ListNode{val: list1.val, next: merge_two_lists(list1.next, list2)}
  end

  def merge_two_lists(list1, list2) when list1.val >= list2.val do
    %ListNode{val: list2.val, next: merge_two_lists(list1, list2.next)}
  end

  def merge_two_lists(list1, nil) do
    list1
  end

  def merge_two_lists(nil, list2) do
    list2
  end
end

defmodule Tests do
  defp list_to_string(list) when list == nil do
    ""
  end

  defp list_to_string(list) do
    "#{list.val} " <> list_to_string(list.next)
  end

  def example1 do
    list1 = %ListNode{val: 1, next: %ListNode{val: 2, next: %ListNode{val: 4}}}
    list2 = %ListNode{val: 1, next: %ListNode{val: 3, next: %ListNode{val: 4}}}
    IO.puts(list_to_string(Solution.merge_two_lists(list1, list2)))
  end

  def example2 do
    IO.puts(list_to_string(Solution.merge_two_lists(nil, nil)))
  end

  def example3 do
    IO.puts(list_to_string(Solution.merge_two_lists(nil, %ListNode{val: 0})))
  end
end

Tests.example1
Tests.example2
Tests.example3