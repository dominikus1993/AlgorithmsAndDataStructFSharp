object Main {
  def main(args: Array[String]) {
    val res  = area(1,1,10)
    println(res)
  }
  def area(l:Int, w:Int ,h:Int)={
    val minimum = List[Int](l, w, h).sortWith((el, el1) => el > el1).take(2).product
    2 * l * w + 2 * w * h + 2 * h * l + minimum
 }
}
