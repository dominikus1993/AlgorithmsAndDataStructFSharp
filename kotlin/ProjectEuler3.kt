import java.util.jar.Attributes

/**
 * Created by dominik on 27.03.16.
 */


class Main {
    fun findFactor(number:Int):List<Int>{
        val uperBound = Math.sqrt(number.toDouble())
        return (2..uperBound.toInt()).filter { x -> number % x == 0 }
    }

    fun isPrime(number: Int):Boolean{
        return findFactor(number).size == 0
    }
    fun main(args : Array<String>) {
        val number = 13195
        val list = (2..Math.sqrt(number.toDouble()).toInt()).filter{x -> number % x == 0}.filter{x -> isPrime(x)}.max()
        print(list)

    }
}
