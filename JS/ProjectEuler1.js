
(function () {

    var list = (function() {
        var tmp = [];
        for (var i = 0; i < 1000; i++) {
            tmp[i] = i;
        }
        return tmp;
    })();

    var filter =function(data) {
        return data.filter(function(x) {
            return x % 5 === 0 || x % 3 === 0;
        });
    }
    var sum = function (data) {
        return data.reduce(function(x, y) {
            return x + y;
        });
    }

    var main = function(data,filterFunc,sumFunc) {
        return sumFunc(filterFunc(data));
    }

    console.log(main(list, filter, sum));
})();

while (true) {
    
}
