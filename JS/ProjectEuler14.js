
var Euler14;
Euler14 = (function () {
    function Euler14() {
        var that = this;
        this.seq = [];
        
        this.generator = function (num) {
            var number = num;
            var res = [num];
            do {
                if (number % 2 === 0) {
                    number = Math.ceil(number / 2);
                    res.push(number);
                } else {
                    number = 3 * number + 1;
                    res.push(number);
                }
            } while (number !== 1)
            return res;
        }
      
        this.getResult = function(to) {
            var res = [];
            for (var i = 1; i < to; i++) {
                res.push(that.generator(i).length);
            }
            return res;
        }
    }
    
    return Euler14;
})();

var result = function() {
    
}
var mySeq = new Euler14().getResult(1000000);
console.log(Math.max.apply(null,mySeq));
while (true) { }
