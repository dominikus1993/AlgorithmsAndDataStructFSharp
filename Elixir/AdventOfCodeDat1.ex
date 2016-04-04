defmodule Utils do
  def floor(text) do
    up |> Enum.map(fn x -> String.split(x, "") end) |> Enum.count(fn x -> x == "(")
    down |> Enum.map(fn x -> String.split(x, "") end) |> Enum.count(fn x -> x == ")")
    up - down
  end
end

IO.inspect Utils.floor("(()(()(")
