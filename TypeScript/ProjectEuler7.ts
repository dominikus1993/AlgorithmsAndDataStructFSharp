

class ListGenerator {
    private list: number[] = [];

    constructor(to: number) {
        var number1 = 2;
        var counter = 0;
        while (counter < to) {
            if (this.isPrime(number1)) {
                this.list.push(number1);
                counter++;
            }
            number1++;
        }
    }

    private isPrime = (numberr: number) => this.generateList(2, Math.sqrt(numberr)).filter(x=> numberr % x == 0).length == 0

    private generateList = function (start, stop) {
        var result: number[] = [];
        for (var i = start; i <= stop; i++) {
            result.push(i);
        }
        return result;
    }

    public getList = () => this.list;
}

var list = new ListGenerator(10000);

console.log(list.getList()[list.getList().length - 1])

while (true) { }
