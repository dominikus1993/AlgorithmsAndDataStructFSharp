main() async {
  var numbers = new Iterable.generate(1000, (i) => i).where((x) => x % 3 == 0 || x % 5 == 0).reduce((acc, x) => acc + x);
  print(numbers);
}
