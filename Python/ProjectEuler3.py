import math

def findFactor(number):
    upperBound = int(math.sqrt(number)) + 1 
    return [x for x in range(2,upperBound) if number % x == 0]

def isPrime(number): 
    return  len(findFactor(number)) == 0

def filterList(number):
    upperBound = int(math.sqrt(number)) + 1
    list = range(2,upperBound)
    return max(filter(lambda x: isPrime(x),filter(lambda y: number % y == 0,list)))

print(filterList(600851475143))
