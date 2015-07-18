list =*(1..1000)
list.select{|x| x % 3 == 0 || x % 5 == 0}.inject{|sum,x| sum + x}