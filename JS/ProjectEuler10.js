
var isPrime = function (number) {
    for (var i = 2; i <= Math.sqrt(number); i++) {
        if (number % i === 0) {
            return false;
        }
    }
    return true;
}

var getList = function (to,func) {
    var result = [];
    for (var i = 2; i < to; i++) {
        if (func(i)) {
            result.push(i);
        }
    }
    return result;
}

console.log(getList(2000000,isPrime).reduce(function(x, y) {
    return x + y;
}));

while (true) { }
