defmodule ListNode do
  @type t :: %__MODULE__{
          val: integer,
          next: ListNode.t() | nil
        }
  defstruct val: 0, next: nil
end

defmodule Solution do
  @spec add_two_numbers(l1 :: ListNode.t | nil, l2 :: ListNode.t | nil) :: ListNode.t | nil
  def add_two_numbers(l1, l2) do
    add(l1, l2, 0)
  end

  defp add(l1, l2, carry) when l1 != nil and l2 != nil do
    {digit, carry} = digit_carry(l1.val + l2.val + carry)
    %ListNode{val: digit, next: add(l1.next, l2.next, carry)}
  end

  defp add(l1, nil, 1) when l1 != nil do
    {digit, carry} = digit_carry(l1.val + 1)
    %ListNode{val: digit, next: add(l1.next, nil, carry)}
  end

  defp add(nil, l2, 1) when l2 != nil do
    {digit, carry} = digit_carry(l2.val + 1)
    %ListNode{val: digit, next: add(nil, l2.next, carry)}
  end

  defp add(nil, nil, 1) do
    %ListNode{val: 1}
  end

    defp add(l1, l2, 0) when l1 == nil or l2 == nil do
    if l1 == nil do
      l2
    else
      l1
    end
  end

  defp digit_carry(total) do
    digit = rem(total, 10)
    carry = div(total, 10)
    {digit, carry}
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
    list1 = %ListNode{val: 2, next: %ListNode{val: 4, next: %ListNode{val: 3}}}
    list2 = %ListNode{val: 5, next: %ListNode{val: 6, next: %ListNode{val: 4}}}
    IO.puts(list_to_string(Solution.add_two_numbers(list1, list2)))
  end

  def example2 do
    list1 = %ListNode{val: 0}
    list2 = %ListNode{val: 0}
    IO.puts(list_to_string(Solution.add_two_numbers(list1, list2)))
  end

  def example3 do
    list1 = %ListNode{val: 9, next: %ListNode{val: 9, next: %ListNode{val: 9, next: %ListNode{val: 9, next: %ListNode{val: 9, next: %ListNode{val: 9, next: %ListNode{val: 9}}}}}}}
    list2 = %ListNode{val: 9, next: %ListNode{val: 9, next: %ListNode{val: 9, next: %ListNode{val: 9}}}}
    IO.puts(list_to_string(Solution.add_two_numbers(list1, list2)))
  end
end

Tests.example1
Tests.example2
Tests.example3