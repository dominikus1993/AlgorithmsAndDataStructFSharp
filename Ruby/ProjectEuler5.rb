list =*(1..21)

def sumSquare(data)
  data.inject(0) { |acc, x| acc + ( x ** 2 ) }
end

def squareSum(data)
  data.inject(0) { |acc, x| acc + x } ** 2
end

puts(sumSquare(list) - squareSum(list))
