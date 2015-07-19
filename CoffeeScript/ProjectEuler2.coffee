data = do -> 
 this.list = [] 
 this.list.push(0) 
 this.list.push(1);
 i = 1

 while this.list[i] <= 40000000

  this.list[i + 1] = this.list[i] + this.list[i - 1]
  i++

 return this.list;



alert data.filter((x) -> x % 2 == 0).reduce((x,y) -> x + y)