defmodule TreeNode do
  @type t :: %__MODULE__{
          val: integer,
          left: TreeNode.t() | nil,
          right: TreeNode.t() | nil
        }
  defstruct val: 0, left: nil, right: nil
end

defmodule Solution do
  def largest_values(nil) do
    []
  end

  @spec largest_values(root :: TreeNode.t | nil) :: [integer]
  def largest_values(root) do
    process_row([root])
  end

  defp process_row([]) do
    []
  end

  defp process_row(node_stack) do
    max_value = case node_stack do
      [node] -> node
      [head | tail] -> Enum.reduce(tail, head, fn x, y -> max_node(x, y) end)
    end

    children_stack = Enum.flat_map(node_stack, fn node -> get_children(node) end)
    [max_value.val | process_row(children_stack)]
  end

  def get_children(node) do
    case node do
      %TreeNode{left: nil, right: nil}  -> []
      %TreeNode{left: nil, right: r}    -> [r]
      %TreeNode{left: l, right: nil}    -> [l]
      %TreeNode{left: l, right: r}      -> [l, r]
    end
  end

  defp max([node]) do
    node
  end

  defp max_node(left_node, right_node) do
    if left_node.val > right_node.val do
      left_node
    else
      right_node
    end
  end
end

defmodule Tests do
  def example1 do
    tree = %TreeNode{val: 10}
    IO.inspect(Solution.largest_values(tree), charlists: :as_lists)
  end

  def example2 do
    tree = %TreeNode{val: 10, left: %TreeNode{val: 6}, right: %TreeNode{val: 50}}
    IO.inspect(Solution.largest_values(tree), charlists: :as_lists)
  end
end

Tests.example1
Tests.example2