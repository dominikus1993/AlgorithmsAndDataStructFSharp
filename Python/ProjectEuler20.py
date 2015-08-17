def factorial(n):
    if n == 0:
        return 1
    else:
        return factorial(n -1) * n
data = [int(x) for x in list(str(factorial(100)))] 
print(sum(data))
