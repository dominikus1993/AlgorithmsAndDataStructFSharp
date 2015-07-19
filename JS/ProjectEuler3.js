var PrimeList = (function () {
    
    function PrimeList(to) {
        this.list = [];

        this.FindFactors(to);

        var self = this;

        this.list = this.list.filter(function (x) {
            return self.isPrime(x);
        });
    }
    
    PrimeList.prototype.FindFactors = function(number) {
        for (var i = 0; i < Math.sqrt(number); i++) {
            if (number % i === 0) {
                this.list.push(i);
            }
        }
    }    
    
    PrimeList.prototype.isPrime = function (number) {
        for (var i = 2; i <= Math.sqrt(number); i++) {
            if (number % i === 0) {
                return false;
            }
        }
        return true;
    }
    
    PrimeList.prototype.getPrimeList = function () {
        return this.list;
    }
    return PrimeList;

})();

Array.prototype.max = function () {
    return Math.max.apply(null, this);
}

var num = 600851475143;

var list = new PrimeList(num).getPrimeList();

console.log(list.max());

while (true);
//# sourceMappingURL=app.js.map
