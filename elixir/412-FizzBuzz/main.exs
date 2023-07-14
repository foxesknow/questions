defmodule Solution do
  @spec fizz_buzz(n :: integer) :: [String.t]
  def fizz_buzz(n) do
    for num <- 1..n, do: make_word(num)
  end

  defp make_word(n) do
    cond do
      rem(n, 15) == 0 -> "FizzBuzz"
      rem(n, 3) == 0  -> "Fizz"
      rem(n, 5) == 0  -> "Buzz"
      true            -> "#{n}"
    end
  end
end

IO.inspect(Solution.fizz_buzz(3))
IO.inspect(Solution.fizz_buzz(5))
IO.inspect(Solution.fizz_buzz(15))