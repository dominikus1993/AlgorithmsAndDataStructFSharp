defmodule Utils do
  def quick_sort([head | tail]) do

    smaller = quick_sort(tail |> Enum.filter(fn x -> x < head end))
    greater = quick_sort(tail |> Enum.filter(fn x -> x >= head end))
    smaller ++ [head] ++ greater

  end

  def quick_sort([]) do
    []
  end
end

IO.inspect Utils.quick_sort([1,5,7,66,11,4,5,2,3])
