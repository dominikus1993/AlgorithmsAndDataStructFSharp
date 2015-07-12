
(function(){
var data = ["aaaa","dupa","ala ma kota"];
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
})();

//shorter version 

(function() {
    var data = ["assasa", "sdadsad", "sassasa"];
    
    var count = function(list,letter) {
        return data.join("").split("").filter(function(x) {
            return x === letter;
        }).length;
    }

    var main = function main(list,letter,func) {
        return func(data,letter);
    }

    console.log(main(data,"a", count));
})();

