word_list = ["aaaa", "dupa", "ala ma kota"]

defmodule WordUtils do
  def word_filter(words, letter) do
    words |> Enum.map(fn x -> String.split(x, "") end) |> Enum.reduce(fn x, acc -> acc ++ x end) |> Enum.filter(fn x -> x == letter end) |> Enum.count
  end
end

IO.inspect WordUtils.word_filter(word_list, "a")
