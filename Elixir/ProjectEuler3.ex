defmodule ProjectEuler3 do
  defp findFactors(number) do
    data = Enum.into 2..(number - 1), []
    data |> Enum.filter(fn x -> rem(number, x) == 0 end)
  end
  defp isPrime(number) do
    findFactors(number) |> Enum.count == 0
  end
  def solve(number) do
    upperBound = :math.sqrt(number)
    data = Enum.into 2..round(upperBound), []
    data |> Enum.filter(fn x -> rem(number, x) == 0 end) |> Enum.filter(fn x -> isPrime(x) end) |> Enum.max
  end
end

IO.inspect  ProjectEuler3.solve(13195)
