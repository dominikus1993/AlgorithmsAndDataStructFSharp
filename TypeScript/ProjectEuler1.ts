class RangeList {
    private range: number[] = [];

    constructor(from: number, to: number) {
        for (var i = from; i < to; i++) {
            this.range.push(i);
        }
    }
    
    toList() {
        return this.range;
    }
}

var main = function() {
    var list: number[] = new RangeList(1, 1000).toList();
    return list.filter(x => x % 5 === 0 || x % 3 === 0).reduce((x,y)=>x + y);
}

console.log(main());