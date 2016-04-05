defmodule ProjectEuler2 do
  defp genFib(a, b, acc, limit) when b < limit do
    genFib(b, a + b, acc ++ [a], limit)
  end
  defp genFib(a, b, acc, limit) when b >= limit do
    acc ++ [a] ++ [b]
  end
  def solve(limit) do
    genFib(0,1,[], limit) |> Enum.filter(fn x -> rem(x, 2) == 0 end) |> Enum.sum
  end
end

IO.inspect  ProjectEuler2.solve(4_000_000)
