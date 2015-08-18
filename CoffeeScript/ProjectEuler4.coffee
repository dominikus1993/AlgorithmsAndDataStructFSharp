

result =
  [[i * j] for i in [1..999] for j in [0..999]].toString().split(",")

alert Math.max result.filter((x) -> x == x.toString().split("").reverse().join(""))...
