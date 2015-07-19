class PrimeList {
    private list: number[] = [];

    constructor(to:number) {
        this.list = [];
        this.findFactor(to);

        this.list = this.list.filter(x => this.isPrime(x));

    }

    private findFactor(num: number) {
        for (var i = 2; i < Math.sqrt(num); i++) {
            if (num % i === 0) {
                this.list.push(i);
            }
        }
    }

    private isPrime(num:number) {
        for (var i = 2; i * i < num; i++) {
            if (num % i === 0) {
                return false;
            }
        }
        return true;
    }

    public getPrimeList() {
        return this.list;
    }
}

var num = 600851475143;
var factorArray = new PrimeList(num).getPrimeList();
console.log(factorArray[factorArray.length - 1]);
while (true) {
    
}