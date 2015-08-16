import math


first = 2
last = math.pow(first,1000)

sumArythmeticSeq = lambda a1,an,n: ((a1 + an) / 2) * n
#data = list(int(sumArythmeticSeq(first,last,1000)))

data = [int(x) for x in list(str(int(sumArythmeticSeq(first,last,1000))))]

print(sum(data,0)) 
