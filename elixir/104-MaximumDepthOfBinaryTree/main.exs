defmodule TreeNode do
  @type t :: %__MODULE__{
          val: integer,
          left: TreeNode.t() | nil,
          right: TreeNode.t() | nil
        }
  defstruct val: 0, left: nil, right: nil
end

defmodule Solution do
  @spec max_depth(root :: TreeNode.t | nil) :: integer
  def max_depth(root) do
    cond do
      root == nil -> 0
      true        -> 1 + (max(max_depth(root.left), max_depth(root.right)))
    end
  end
end

defmodule Tests do
  defp list_to_string(list) do
    "#{list.val} " <> list_to_string(list.next)
  end

  def example1 do
    tree = %TreeNode{val: 3, left: %TreeNode{val: 9}, right: %TreeNode{val: 20, right: %TreeNode{val: 7}}}
    IO.puts(Solution.max_depth(tree))
  end
end

Tests.example1