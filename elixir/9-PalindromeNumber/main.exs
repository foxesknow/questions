defmodule Solution do
    @spec reverse(x :: integer, acc :: integer) :: integer
    defp reverse(x, acc) do
        if x == 0 do
            acc
        else
            reverse(div(x, 10), (acc * 10) + rem(x, 10)) 
        end
    end

    @spec is_palindrome(x :: integer) :: boolean
    def is_palindrome(x) when x < 0 do
        false
    end

    @spec is_palindrome(x :: integer) :: boolean
    def is_palindrome(x) when x == 0 do
        true
    end
  
    @spec is_palindrome(x :: integer) :: boolean
    def is_palindrome(x) do
        reverse(x, 0) == x
    end
end

IO.puts(Solution.is_palindrome(121))
IO.puts(Solution.is_palindrome(-121))
IO.puts(Solution.is_palindrome(10))