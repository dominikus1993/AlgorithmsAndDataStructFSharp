class List {
    private list: number[] = [];

    constructor(to:number) {
        for (var i = 1; i < to + 1; i++) {
                this.list.push(i);
        }
    }

    getList() {
        return this.list;
    }
}

var findSmallestNumberDividedByWholeNumberFrom1To20  = (n: number, listNumber: number[]) => {
    if (listNumber.filter(x=>n % x !== 0).length > 0) {
        return findSmallestNumberDividedByWholeNumberFrom1To20(n + 1, listNumber);
    } else {
        return n;
    }
}
var list = new List(20).getList();
console.log(findSmallestNumberDividedByWholeNumberFrom1To20(2,list));
while (true) {
    
}
