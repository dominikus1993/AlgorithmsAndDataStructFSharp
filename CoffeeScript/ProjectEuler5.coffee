list = [1..21]

sumSqure = (data) ->
  data.reduce((x, y) -> x + (y * y))

squareSum = (data) ->
  Math.pow(data.reduce((x, y) -> x + y),2)

document.write(squareSum(list) - sumSqure(list))
