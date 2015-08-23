val list = List.range(1,21)

val sumSquare = (data:List[Int]) =>{
  data.fold(1)((acc,x) =>  acc + (x * x))
}

val squareSum = (data:List[Int]) => {
  Math.pow(data.fold(0)(_+_),2)
}

val sum = sumSquare(list)
val sum2 = squareSum(list)

val result = sum2 - sum
