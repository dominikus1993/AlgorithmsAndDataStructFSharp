import scala.annotation.tailrec

/**
  * Created by domin_000 on 23.01.2016.
  */
object Main {
  def main(args: Array[String]) {
    val text = "ugknbfddgicrmopn"
    println(isNice(text))
  }

  def isNice(text: String): Boolean = {
    val atLeastThreeVowels = text.toCharArray.count(x => isVowel(x)) >= 3
    val containsDoubleLetter = checkText(text, (x, y) => x == y)
    val containsSpecialStrings = checkText(text, (x, y) => check(x.toString + y.toString))
    atLeastThreeVowels && containsDoubleLetter && !containsSpecialStrings
  }

  def isVowel(c: Char): Boolean = c match {
    case ('a' | 'e' | 'i' | 'o' | 'u') => true
    case (_) => false
  }

  def check(text: String): Boolean = text match {
    case ("ab" | "cd" | "pq" | "xy") => true
    case (_) => false
  }

  def checkText(text: String, filter: (Char, Char) => Boolean): Boolean = {
    val charArray = text.toCharArray
    (for (x <- List.range(0, charArray.length - 1)) yield (charArray(x), charArray(x + 1))).exists(x => filter(x._1, x._2))
  }

}
