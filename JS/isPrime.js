
(function() {
    var isPrime  = function isPrime(number, n) {
        if (number === 1) {
            return false;
        } else if (n === Math.ceil(Math.sqrt(number))) {
            return (number % n) === 0;
        } else {
            return isPrime(number, n - 1) || (number % n === 0);
        }
    }
    var main = function (number,func) {
            return !func(number, number - 1);
        }

        console.log(main(3,isPrime));
})();

while (true) {
    
}
