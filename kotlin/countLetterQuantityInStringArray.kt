object  Main {

    fun count(list:List<String>, letter:Char):Int{
        return list.sumBy { x -> x.toCharArray().filter { y -> y == letter }.size }
    }

    fun main(args : Array<String>) {
        println(count(arrayListOf("aaaa","dupa","ala ma kota"), 'a'))
    }
}
