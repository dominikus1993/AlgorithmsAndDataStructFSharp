
var data = ["aaaa","dupa","ala ma kota"];
var text = "fdhfsfsd";
var toCharArray = function(word){
	return word.split('');
}

var main = function(list,word,func){
	var result = 0;
	for (var i = 0; i < list.length; i++) {
			var charArray = func(list[i]);

			for (var j = 0; j < charArray.length; j++) {
				if (charArray[j] == word) {
					result++;
				};
			};
	};
	return result;
}

console.log(main(data,'a',toCharArray))

