class Main {
    fun main(args : Array<String>) {
        val quantity = 1000;
        val res = (1..quantity - 1).asSequence().filter { x -> x % 3 == 0  || x % 5 == 0}.sum()
        println(res)
    }
}
