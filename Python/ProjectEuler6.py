import math;
numbers = range(1,21)
squareSum = sum([x *x for x in numbers]);
sumSquare  = math.pow(sum(numbers),2);
print(sumSquare - squareSum)
