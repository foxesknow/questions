defmodule Solution do
  def convert_to_base7(0),                 do: "0"
  def convert_to_base7(num) when num < 0,  do: "-" <> convert_to_base7(abs(num))
  def convert_to_base7(num),               do: convert(num, "")

  defp convert(0, acc), do: acc

  defp convert(num, acc) do
    digit = rem(num, 7)
    num = div(num, 7)

    convert(num, "#{digit}" <> acc)
  end
end

IO.inspect(Solution.convert_to_base7(100))
IO.inspect(Solution.convert_to_base7(-7))
IO.inspect(Solution.convert_to_base7(0))