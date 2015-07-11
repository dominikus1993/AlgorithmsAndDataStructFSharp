(function() {

    var data = [1, 2, 3, 8, 9, 10, 11, 14, 15, 16, 17];

    var countSeq = function(list) {
        var result = 0;
        for (var i = 0; i < list.length - 2; i++) {
            if (Math.abs(list[i] - list[i + 1]) === Math.abs(list[i + 2] - list[i + 1])) {
                result++;
            }
        }
        return result;
    }

    var main = function(list, func) {
        return func(list);
    }


    console.log(main(data, countSeq));

})();

