def fib():
   a,b = 0,1
   yield a
   yield b
   while 40000000 >= b:
    a,b = b,a+b
    yield b
 

print(sum(filter(lambda x: x % 2 == 0,fib())))
    
       