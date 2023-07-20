defmodule TreeNode do
  @type t :: %__MODULE__{
          val: integer,
          left: TreeNode.t() | nil,
          right: TreeNode.t() | nil
        }
  defstruct val: 0, left: nil, right: nil
end

defmodule Solution do
  @spec is_same_tree(p :: TreeNode.t | nil, q :: TreeNode.t | nil) :: boolean
  def is_same_tree(p, q) do
    cond do
      p == nil and q == nil -> true
      p == nil and q != nil -> false
      p != nil and q == nil -> false
      true -> p.val == q.val and is_same_tree(p.left, q.left) and is_same_tree(p.right, q.right)
    end
  end
end


defmodule Tests do
  def example1 do
    p = %TreeNode{val: 1, left: %TreeNode{val: 2}, right: %TreeNode{val: 3}}
    q = %TreeNode{val: 1, left: %TreeNode{val: 2}, right: %TreeNode{val: 3}}
    Solution.is_same_tree(p, q) |> IO.inspect()
  end

  def example2 do
    p = %TreeNode{val: 1, left: %TreeNode{val: 2}}
    q = %TreeNode{val: 1, right: %TreeNode{val: 2}}
    Solution.is_same_tree(p, q) |> IO.inspect()
  end
end

Tests.example1
Tests.example2