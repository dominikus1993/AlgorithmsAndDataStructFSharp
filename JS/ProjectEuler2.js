var FibSeq = (function() {
    function FibSeq() {
        this.list = [];
        this.list.push(0);
        this.list.push(1);
        var i = 1;

        while (this.list[i] < 40000000) {
            this.list[i + 1] = this.list[i] + this.list[i - 1];
            i++;
        }
    };

    FibSeq.prototype.getFibSeq = function() {
        return this.list;
    };
    return FibSeq;
})();

var fibSeq = new FibSeq().getFibSeq();
console.log(fibSeq.filter(function(x) {
    return x % 2 === 0;
}).reduce(function(x,y) {
    return x + y;
}));

while (true);
//# sourceMappingURL=app.js.map
