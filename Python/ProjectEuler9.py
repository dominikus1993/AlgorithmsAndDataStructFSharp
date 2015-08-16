import _functools
from _functools import reduce

def data():
    for a in range(1,1000):
        for b in range(a,1000):
            c = 1000 - a - b;
            if c  > 0: 
                if a * a + b * b == c * c:
                    yield [a,b,c]


print(reduce(lambda x,y: x * y,list(data())[0],1))
         
                  
