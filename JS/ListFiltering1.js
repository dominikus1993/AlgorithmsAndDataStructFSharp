
var data = ["a", "b", "c", "d", "e"];

var filter = function (list) {
    var newList = [];
    list.forEach(function (x) {
        if (x === "a" || x === "e") {
            newList.push(x);
        }
    });
    return newList;
}

console.log(filter(data));
while (true) {
    
}

