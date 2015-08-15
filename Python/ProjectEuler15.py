
def factorial(n):
    if n == 0: 
        return 1
    else:
        return factorial(n - 1) * n


combination = lambda n,k: factorial(n) / (factorial(k)  * factorial(n - k))

print(combination(40,20)) 
