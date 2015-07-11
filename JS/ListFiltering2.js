
var data = (function () {
    var result = [];
    for (var i = 1; i < 100; i++) {
        result[i] = i * i;
    }
    return result;
})();

var filterFunc = function(item) {
    return item % 3 === 0;
}


var filter = function (list,conditionFunc) {
    var newList = [];
    list.forEach(function (x) {
        if (conditionFunc(x)) {
            newList.push(x);
        }
    });
    return newList;
}

console.log(filter(data,filterFunc));
while (true) {
    
}

