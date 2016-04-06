defmodule AdventOfCode2 do
  defp area(l, w, h) do
    min = [l, w, h] |> Enum.sort |> Enum.take(2) |> Enum.reduce(fn acc, x -> acc * x end)
    (2* (l * w)) + (2 * (w * h)) + (2 * (l * h)) + min
  end
  def solve(l, w, h) do
    area(l, w, h)
  end
end
