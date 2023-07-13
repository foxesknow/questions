defmodule ListNode do
  @type t :: %__MODULE__{
          val: integer,
          next: ListNode.t() | nil
        }
  defstruct val: 0, next: nil
end

defmodule Solution do
  defp list_node_length(nil),  do: 0
  defp list_node_length(node), do: 1 + list_node_length(node.next)

  def rotate_right(head, 0), do: head
  def rotate_right(nil, _),  do: nil

  @spec rotate_right(head :: ListNode.t | nil, k :: integer) :: ListNode.t | nil
  def rotate_right(head, k) do
    length = list_node_length(head)
    shift = rem(k, length)

    new_tail = copy(head, length - shift, nil)
    new_head = skip(head, length - shift)
    copy(new_head, shift, new_tail)
  end

  defp copy(_, 0, tail),        do: tail
  defp copy(node, count, tail), do: %ListNode{val: node.val, next: copy(node.next, count - 1, tail)}

  defp skip(node, 0),     do: node
  defp skip(node, count), do: skip(node.next, count - 1)
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
    IO.puts(list_to_string(Solution.rotate_right(list, 2)))
  end

  def example2 do
    list = %ListNode{val: 0, next: %ListNode{val: 1, next: %ListNode{val: 2}}}
    IO.puts(list_to_string(Solution.rotate_right(list, 4)))
  end

  def example3 do
    list = %ListNode{val: 0, next: %ListNode{val: 1, next: %ListNode{val: 2}}}
    IO.puts(list_to_string(Solution.rotate_right(list, 0)))
  end
end

Tests.example1
Tests.example2
Tests.example3