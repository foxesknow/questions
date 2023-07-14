defmodule Solution do
  @name __MODULE__

  defp start(nums) do
    Agent.start_link(fn -> nums end, name: @name)
  end

  defp restart(nums) do
    Agent.stop(@name)
    start(nums)
  end

  @spec init_(nums :: [integer]) :: any
  def init_(nums) do
    case start(nums) do
      {:ok, _} -> nil
      {:error, {:already_started, _}} -> restart(nums)
    end
  end

  @spec reset() :: [integer]
  def reset() do
    Agent.get_and_update(@name, fn nums -> {nums, nums} end)
  end

  @spec shuffle() :: [integer]
  def shuffle() do
    Agent.get_and_update @name, fn nums ->
      {Enum.shuffle(nums), nums}
    end
  end
end

defmodule Tests do
  def example1 do
    Solution.init_([1,2,3])
    IO.inspect(Solution.shuffle())
    IO.inspect(Solution.reset())
    IO.inspect(Solution.shuffle())

    Solution.init_([1,2])
    IO.inspect(Solution.shuffle())
    IO.inspect(Solution.reset())
    IO.inspect(Solution.shuffle())
  end
end

Tests.example1