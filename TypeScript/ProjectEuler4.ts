class MultipierList {
    private list: number[] = [];

    constructor() {
        for (var i = 100; i < 999; i++) {
            for (var j = 100; j < 999; j++) {
                this.list.push(i * j);
            }
        }
    }

    getList() {
        return this.list;
    }
}


var list = new MultipierList().getList();
console.log(Math.max.apply(null,list.filter(x=>x.toString() === x.toString().split("").reverse().join(""))));
while (true) {
    
}
