
(function() {
    var data = [1, 2, 3, 4, 5, 6, 4, 5];
    var sum = function (list) {
        return list.reduce(function(x, y) {
            return x + y;
        });
    }

    var main = function (list, func) {
        return func(list) / list.length;
    }

    console.log(main(data, sum));
})();

while (true) {
    
}
