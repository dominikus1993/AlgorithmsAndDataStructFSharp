list = Enum.into 1..1000, []
sum = fn data ->
  data |> Enum.filter(fn x -> rem(x, 5) == 0 && rem(x, 3) == 0 end) |> Enum.sum
end

IO.inspect sum.(list)
