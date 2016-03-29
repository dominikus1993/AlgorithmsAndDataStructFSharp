    fun quickSort(array:List<Int>):List<Int>{
        if(array.size == 0){
            return listOf()
        }
        else{
            val head = array.first()
            val tail = array.subList(1, array.size - 1)
            val smaller = quickSort(tail.filter { x -> head > x })
            val greater = quickSort(tail.filter { x -> head <= x })

            return smaller.plus(head).plus(greater)
        }
    }
    fun main(args : Array<String>) {
        val array = arrayListOf(1,5,7,89,77,5,1,66,444)
        val list = quickSort(array)
        print(list)
    }
