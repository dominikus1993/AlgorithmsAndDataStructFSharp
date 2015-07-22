var MultipierList = (function () {
    function MultipierList() {
        this.list = [];
        for (var i = 100; i < 999; i++) {
            for (var j = 100; j < 999; j++) {
                this.list.push(i * j);
            }
        }
    }
    MultipierList.prototype.getList = function () {
        return this.list;
    };
    return MultipierList;
})();

var list = new MultipierList().getList();
console.log(Math.max.apply(null, list.filter(function (x) {
    return x.toString() === x.toString().split("").reverse().join("");
})));
while (true) {
}
//# sourceMappingURL=app.js.map
