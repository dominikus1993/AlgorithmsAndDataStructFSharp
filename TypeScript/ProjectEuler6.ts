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


var list = new List(20).getList();

var sumSquare = (data:number[]) => {
    return data.reduce((x, y) => x + (y * y));
}

var squareSum = (data:number[]) => {
    return Math.pow(data.reduce((x, y) => x + y),2);
}

console.log(squareSum(list) - sumSquare(list));
while (true) {
    
}
