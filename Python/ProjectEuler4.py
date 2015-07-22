
numbers = list(range(100,999))
list = [x * y for x in numbers for y in numbers]

print(max(filter(lambda x: str(x) == str(x)[::-1],list)))
