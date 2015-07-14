
(function() {
    var data = ["a", "a", "a", "a", "b", "c", "c", "a", "a", "d", "e", "e", "e", "e"];
    var data2 = [1, 2, 3, 4, 5, 6, 4, 5];
    var collect = function (list) {
        return list.filter(function(x, i) {
            return x !== list[i + 1];
        });
    }

    var main = function (list, func) {
        return func(list);
    }

    console.log(main(data, collect));
})();

while (true) {
    
}
