
var Euler20;
Euler20 = (function() {
    function Euler20() {
        var that = this;
        this.factorial = function factorial(n) {
            if (n == 0) {
                return 1;
            } else {
                return factorial(n - 1) * n;
            }
        }
        this.getResult = function(num) {
            var res = that.factorial(num);
            return res.toString(10);
        }
    }

    return Euler20;
})();

var mySeq = new Euler20().getResult(100).split("").map(function(x) {
    return parseInt(x, 10);
}).reduce(function(x, y) {
    return x + y;
});
console.log(mySeq);
while (true) { }
