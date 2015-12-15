var quickSort = (array : number[]):number[] => {
  switch(array.length){
    case 0:
      return [];
    default:
      var [head, ...tail] = array;
      var smaller = quickSort(tail.filter(x => x <= head));
      var greater = quickSort(tail.filter(x => x >= head));
      return smaller.concat([head]).concat(greater);
  }
};

console.log(quickSort([1,5,77,2,3,11,44]))
