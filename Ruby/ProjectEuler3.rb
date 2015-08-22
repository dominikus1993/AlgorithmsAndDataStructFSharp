class DataGenerator
  def self.findFactor(number)
    upperBound = Math.sqrt(number)
    return (2..(upperBound)).select{|x| number % x == 0}
  end
  def self.isPrime(number)
    return self.findFactor(number).size == 0
  end
end

number = 13195
list = (2..Math.sqrt(number)).select{|x| number % x == 0}.select{|x| DataGenerator.isPrime(x)}.max
puts(list)
