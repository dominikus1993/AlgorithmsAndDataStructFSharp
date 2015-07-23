list = range(1,21)

def findDivider(n,numbers):
    if len([x for x in numbers if n % x != 0]) > 0:
        return findDivider(n+1,numbers)
    else:
        return n;


print(findDivider(2,list))
