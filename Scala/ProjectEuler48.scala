object Main {
  def main(args: Array[String]) {
    val sum = List.range(1,1000).map(x => BigInt(x).pow(x)).sum.toString();
    println(sum.substring(sum.length - 10, sum.length))
  }
}
