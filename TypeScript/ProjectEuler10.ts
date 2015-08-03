
class Euler10 {
    private list = [];
    

    constructor(to) {
        this.list = this.listGenerator(to,this.isPrime);
    }
    
    private listGenerator = (to: number,func:Function) => {
        var result:number[] = [];
        for (let i = 2; i < to; i++) {
            if (func(i)) {
                result.push(i);
            }
        }
        return result;
    }

    private isPrime = (num:number):boolean => {
        for (let i = 2; i <= Math.sqrt(num); i++) {
            if (num % i === 0) {
                return false;
            }
        }
        return true;
    }

    public getList = (): number[] => {
        return this.list;
    }
}

console.log(new Euler10(2000000).getList().reduce((x,y)=>x+y));
while (true) { }
