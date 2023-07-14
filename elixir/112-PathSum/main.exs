defmodule TreeNode do
  @type t :: %__MODULE__{
          val: integer,
          left: TreeNode.t() | nil,
          right: TreeNode.t() | nil
        }
  defstruct val: 0, left: nil, right: nil
end

defmodule Solution do
  def has_path_sum(nil, _) do
    false
  end

  def has_path_sum(root, target_sum) when root.left == nil and root.right == nil do
    target_sum - root.val == 0
  end

  @spec has_path_sum(root :: TreeNode.t | nil, target_sum :: integer) :: boolean
  def has_path_sum(root, target_sum) do
    has_path_sum(root.left, target_sum - root.val) or has_path_sum(root.right, target_sum - root.val)
  end
end

defmodule Tests do
  def example1 do
    tree = %TreeNode{val: 1, left: %TreeNode{val: 2}, right: %TreeNode{val: 3}}
    IO.puts(Solution.has_path_sum(tree, 3))
  end

  def example2 do
    tree = %TreeNode{val: 1, left: %TreeNode{val: 2}, right: %TreeNode{val: 3}}
    IO.puts(Solution.has_path_sum(tree, 4))
  end

  def example3 do
    tree = %TreeNode{val: 1, left: %TreeNode{val: 2}, right: %TreeNode{val: 3}}
    IO.puts(Solution.has_path_sum(tree, 1))
  end
end

Tests.example1
Tests.example2
Tests.example3