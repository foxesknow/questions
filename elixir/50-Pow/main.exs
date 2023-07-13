defmodule Solution do
  def my_pow(x, n) when x == 1 or n == 0 do
    1
  end

  def my_pow(x, 1),   do: x
  def my_pow(x, -1),  do: 1/x
  def my_pow(0, _),   do: 0

  @spec my_pow(x :: float, n :: integer) :: float
  def my_pow(x, n) do
    half = my_pow(x, div(n, 2))
    result = half * half

    if rem(abs(n), 2) == 1 do
      sign = if n > 0, do: 1, else: -1
      result * my_pow(x, sign)
    else
      result
    end
  end
end

IO.inspect(Solution.my_pow(2, 10))
IO.inspect(Solution.my_pow(2.1, 3))
IO.inspect(Solution.my_pow(2.0, -2))
IO.inspect(Solution.my_pow(-2, 2))
IO.inspect(Solution.my_pow(-2, 3))