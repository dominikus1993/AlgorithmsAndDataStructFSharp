class Testy {
  def findFactor(number:Int):List[Int] = {
    List.range(2,number).filter(x => number % x == 0)
  }

  def isPrime(number:Int):Boolean = {
      return findFactor(number).isEmpty
  }

}

val euler = new Testy()
val number  = 13195
val reslut = List.range(1,number).filter(x => number % x == 0).filter(x => euler.isPrime(x)).max()

