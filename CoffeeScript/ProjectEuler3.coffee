findFactor = (number) ->
  upperBound = Math.ceil(Math.sqrt(number))
  [2..upperBound].filter( (x) -> number % x == 0 )

isPrime = (number) ->
  findFactor(number).length == 0

filterList = (number) ->
  upperBound = Math.ceil(Math.sqrt(number))
  Math.max [2..upperBound].filter((x) -> number % x == 0).filter((x) -> isPrime(x))...

document.write filterList(13195)
