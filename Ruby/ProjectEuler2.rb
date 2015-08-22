class DataGenerator
  def self.generate()
     list = Array.new
     i = 1
     list.push(0)
     list.push(1)
     while list[i] <= 4000000
       list[i + 1] = list[i] + list[i - 1]
       i+=1
     end
     return list
  end
end

list = DataGenerator.generate().select{|x| x % 2 == 0}.inject(0) { |x, y| x + y }
puts(list)
