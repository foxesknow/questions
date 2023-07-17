defmodule ListNode do
  @type t :: %__MODULE__{
          val: integer,
          next: ListNode.t() | nil
        }
  defstruct val: 0, next: nil
end

defmodule Solution do
  def reverse_list(nil) do
    nil
  end

  @spec reverse_list(head :: ListNode.t | nil) :: ListNode.t | nil
  def reverse_list(head) do
    reverse(head, nil)
  end

  defp reverse(%ListNode{val: x, next: nil}, acc) do
    %ListNode{val: x, next: acc}
  end

  defp reverse(%ListNode{val: x, next: link}, acc) do
    reverse(link, %ListNode{val: x, next: acc})
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
    list = %ListNode{val: 1, next: %ListNode{val: 2, next: %ListNode{val: 3, next: %ListNode{val: 4, next: %ListNode{val: 5}}}}}
    IO.puts(list_to_string(Solution.reverse_list(list)))
  end

  def example2 do
    list = %ListNode{val: 0, next: %ListNode{val: 1, next: %ListNode{val: 2}}}
    IO.puts(list_to_string(Solution.reverse_list(list)))
  end

  def example3 do
    list = %ListNode{val: 0, next: %ListNode{val: 1, next: %ListNode{val: 2}}}
    IO.puts(list_to_string(Solution.reverse_list(list)))
  end
end

Tests.example1
Tests.example2
Tests.example3