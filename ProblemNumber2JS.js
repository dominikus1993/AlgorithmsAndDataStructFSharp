var array = [1,2,3,4,5,6,7];

var filter = function(list){
  list.pop();
  return list.reverse()[0];
}

var func = function(filter,list) {
  return filter(list);
}

console.log(func(filter,array));
