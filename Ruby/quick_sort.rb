def quick_sort(list)
  raise 'list must be array or something collection' unless list.kind_of?(Array)
  case list.length
    when 0 then
      []
    else
      head, *tail = list
      smaller = quick_sort(tail.select { |x| x <= head })
      larger = quick_sort(tail.select { |x| x >= head })
      (smaller.concat([head])).concat(larger)
  end
end


puts(quick_sort([5,4,2,1,77,8,555,44444]))
