import scala.annotation.tailrec

/**
  * Created by domin_000 on 23.01.2016.
  */
object Main {
  def main(args: Array[String]) {
    val turns = countTurns("><><><><><><")
    val res = distinct(turnPosition(turns), List[(Int,Int)]()).length
    println(s"delivers presents to ${res} houses: one at the starting location, and one to the east.")
  }

  def turns(sign: Char): (Int, Int) = sign match {
    case ('^') => (0, 1)
    case ('v') => (0, -1)
    case ('<') => (-1, 0)
    case ('>') => (1, 0)
    case (_) => (0, 0)
  }

  def countTurns(text: String): List[(Int, Int)] = {
    text.toCharArray.map(x => turns(x)).toList
  }

  def turnPosition(turns: List[(Int, Int)]): List[(Int, Int)] = {
    @tailrec
    def position(list:List[(Int, Int)], xpos:Int, ypos:Int, acc:List[(Int, Int)]):List[(Int, Int)] = list match {
      case (Nil) => acc
      case ((x, y) :: tail) => position(tail, xpos + x, ypos + y, acc ::: List[(Int, Int)]((xpos + x, ypos + y)))
    }
    position(turns, 0, 0, List[(Int, Int)]((0, 0)))
  }

  @tailrec
  def distinct(turns: List[(Int, Int)], acc: List[(Int, Int)]): List[(Int,Int)] = turns match {
    case (Nil) => acc
    case ((x, y) :: tail) if !acc.exists(a => a._1 == x && a._2 == y) => distinct(tail, (x,y) :: acc)
    case ((x, y) :: tail) => distinct(tail, acc)
  }
}
