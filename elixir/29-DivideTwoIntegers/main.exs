defmodule Solution do
  @spec divide(dividend :: integer, divisor :: integer) :: integer
  def divide(dividend, divisor) do
    sign_adjustment = sign(dividend) * sign(divisor)

    dividend = abs(dividend)
    divisor = abs(divisor)

    case sign_adjustment * Range.size(1..dividend - divisor + 1 // divisor) do
      x when x > 2147483647 -> 2147483647
      x when x < -2147483648 -> -2147483648
      x -> x
    end
  end

  defp sign(number) do
    if number < 0 do
      -1
    else
      1
    end
  end
end

Solution.divide(10, 3) |> IO.inspect()
Solution.divide(8, 3) |> IO.inspect()
Solution.divide(1, 3) |> IO.inspect()
Solution.divide(7, -3) |> IO.inspect()
Solution.divide(7, 7) |> IO.inspect()
Solution.divide(-2147483648, -1) |> IO.inspect()