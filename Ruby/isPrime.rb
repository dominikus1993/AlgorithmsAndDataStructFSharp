def prime?(number)
  array =*(2..Math.sqrt(number))
  array.select{|x| number % x == 0}.length == 0
end

puts(prime?(17))
