interface ISumOfArythmeticSeqFunc<T> {
    (data: T): number
}
class Euler16Data {
    get first(){
        return this._first;
    }

    get last() {
        return this._last;
    }

    get quantity() {
        return this._count;
    }

    constructor(private _first, private _last, private _count) {
    }
}

class Euler16 {
    
    public sumArythmeticSeq = (func: ISumOfArythmeticSeqFunc<Euler16Data>) => {
        return (data: Euler16Data) => {
            return func(data);
        };
    }


}

var last = Math.pow(2, 1000);
var func: ISumOfArythmeticSeqFunc<Euler16Data> = (data) => ((data.first + data.last) / 2) * data.quantity;
var euler16Data = new Euler16Data(2, last, 1000);
var result = new Euler16().sumArythmeticSeq(func);
console.log(result(euler16Data).toString().split("").reduce((x,y) => x + y));
while (true);
