class Testy {
  def sumListElements(data:List[Int]):Int = {
    return data.filter(x => x % 3 == 0 || x % 5 == 0).foldLeft(0)(_+_)
  }
}

val a = new Testy().sumListElements(List.range(1,1000))

a
