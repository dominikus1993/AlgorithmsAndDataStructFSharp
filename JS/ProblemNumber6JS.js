
var data = "potop";

var isPalindrom = function(list) {
	for (var i = 0; i < list.length / 2; i++) {
		if (list[i] != list[list.length - 1 - i]) {
			return false;
		};
	};
	return true;
}

var main = function(list,func){
	return func(list);
}
console.log(main(data,isPalindrom))
console.log(data)

