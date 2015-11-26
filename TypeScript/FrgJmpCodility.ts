const solve = (startVal, dVal, endVal, count) => {
  if (startVal >= endVal) {
      return count;
  }
  else{
    return solve(startVal + dVal, dVal, endVal, count + 1);
  }
}

const solution = (x, y, d) => {
  return solve(x, d, y, 0);
}

console.log(solution(10,85,30))
