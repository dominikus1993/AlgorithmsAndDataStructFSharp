words = ['aaaa', 'dupa', 'ala ma kota']

def count_letter_in_string(words, sign)
  words.inject(0){|acc, x| x.chars.to_a.select{|letter| letter == sign }.length + acc}
end

puts(count_letter_in_string(words, 'a'))

