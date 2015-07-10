var array = [1,2,3,4,5,6,7];

var filter = function(list,index){
  return list[index-1];
}

var func = function(filter,list) {
  return filter(list,2);
}

console.log(func(filter,array));
