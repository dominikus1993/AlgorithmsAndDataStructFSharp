
(function() {
    var data = (function () {
        var arr = [];
        for (var i = 0; i < 100; i++) {
            arr[i] = i;
        }
        return arr;
    })().filter(function(x) {
        return x > 50;
    });
    
    var sort = function(a, b) {
        if (a % 2 === 0) {
            return -1;
        }
        else if (b % 2 === 0) {
            return 1;
        } else {
            return 0;
        }
    }

    var main = function (list, func) {
        return data.sort(func);
    }

    console.log(main(data, sort));
})();

while (true) {
    
}
