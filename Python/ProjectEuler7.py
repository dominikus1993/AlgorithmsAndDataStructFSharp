
import math

def isPrime(number):
   return len([x for x in range(2,int(math.sqrt(number))+1) if number % x == 0 ]) == 0

def generator(first):
    def wrap(func,filterFunc):
        def seq(to):
            x = first
            counter = 0 
            while counter < to:
                if filterFunc(x):
                    counter = counter + 1
                    yield x
                x = func(x)
        return seq
    return wrap

result = list(generator(2)(lambda x: x + 1,lambda x: isPrime(x))(10000))

print(result[::-1][0])
