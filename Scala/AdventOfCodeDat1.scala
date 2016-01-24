/**
  * Created by domin_000 on 23.01.2016.
  */
object Main {
  def main(args: Array[String]) {
    val res  = floor("(()(()(")
    println(res)
  }
  def floor(text:String): Int ={
    val up = text.toCharArray.count(x => x == '(')
    val down = text.toCharArray.count(x => x == ')')
    up - down
  }
}
