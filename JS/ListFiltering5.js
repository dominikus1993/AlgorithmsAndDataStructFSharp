
(function() {
    var data = (function() {
        var arr = [];
        for (var i = 0; i < 10; i++) {
            arr[i] = i;
        }
        return arr;
    })();
    Array.prototype.flatMap = function(x) {
        return Array.prototype.concat.apply([], this.map(x));
    }

    var collect = function (list) {
        return list.flatMap(function (x) {
            return [x,x];
        });
    }

    var main = function (list, func) {
        return func(list);
    }

    console.log(main(data, collect));
})();

while (true) {
    
}
