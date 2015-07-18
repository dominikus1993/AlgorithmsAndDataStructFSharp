class FibSeq {
    private list: number[] = [];

    constructor() {
        this.list.push(0);
        this.list.push(1);
        var i = 1;
        while (this.list[i] < 40000000) {
            this.list[i + 1] = this.list[i] + this.list[i - 1];
            i++;
        }
    }
    
    public getFibSequence() {
        return this.list;
    }
}

var fibSeq = new FibSeq().getFibSequence();
console.log(fibSeq.filter(x => x % 2 === 0).reduce((x, y) => x + y));
while (true) {
    
}