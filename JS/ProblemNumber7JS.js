
(function() {
    var data = [[1,2,3],[10,1,1],1,[1515,11]];
    
    var flatten = function(list) {
        return list.reduce(function(x, y) {
            return x.concat(y);
        });
    }

    var main = function main(list,func) {
        return func(data);
    }

    console.log(main(data, flatten));
})();

while (true) {
    
}
