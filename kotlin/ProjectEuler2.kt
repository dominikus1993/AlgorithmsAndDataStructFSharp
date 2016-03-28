
class Main {
    fun fibSeq(condition:Int):List<Int>
    {
        var firstNumber = 1;
        var secondNumber = 0;
        var res = arrayListOf(secondNumber)

        while (firstNumber < condition)
        {
            res.add(firstNumber)
            val tmp = firstNumber;
            firstNumber += secondNumber;
            secondNumber = tmp;
        }
        return res
    }
    fun main(args : Array<String>) {
        val quantity = 40000000;
        val res = fibSeq(quantity).filter { x -> x % 2 == 0 }.sum()
        println(res)

    }
}
