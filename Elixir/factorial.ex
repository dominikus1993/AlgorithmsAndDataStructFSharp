defmodule Utils do
  def factorial(n) when n > 0 do
    n * factorial(n - 1)
  end
  def factorial(0) do
    1
  end
end

IO.puts Utils.factorial(5)
