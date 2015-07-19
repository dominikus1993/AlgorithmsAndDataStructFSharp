list = [1..1000].filter((x) -> x % 3 == 0 || x % 5 == 0 ).reduce((x,y)->x+y)
alert list