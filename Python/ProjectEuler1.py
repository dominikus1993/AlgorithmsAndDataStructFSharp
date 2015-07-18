list = range(1,1000)
print(sum(filter(lambda x: x%3 == 0 or x%5 == 0,list)))
