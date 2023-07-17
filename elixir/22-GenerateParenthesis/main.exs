defmodule Solution do
  @spec generate_parenthesis(n :: integer) :: [String.t]
  def generate_parenthesis(n) do
    recurse("", 0, 0, n, [])
  end

  defp recurse(current, open, close, n, acc) when open == n and close == n do
    [current | acc]
  end

  defp recurse(current, open, close, n, acc) do
    acc = if open < n do
            recurse(current <> "(", open + 1, close, n, acc)
          else
            acc
          end

    acc = if close < open do
            recurse(current <> ")", open, close + 1, n, acc)
          else
            acc
          end
    acc
  end
end

IO.inspect(Solution.generate_parenthesis(1))
IO.inspect(Solution.generate_parenthesis(3))