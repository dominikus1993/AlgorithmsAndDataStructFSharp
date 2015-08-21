using System.Collections.Generic;
using System.Linq;

namespace TestCSharp
{
    public class Euler21
    {
        private IEnumerable<int> FindDivisor(int number)
        {
            return Enumerable.Range(1, (number/2) + 1).Where(x => number%x == 0).ToList();
        }

        private int D(int number)
        {
            return FindDivisor(number).Sum();
        }

        private List<int> SearchAmicableNumbers(int number, List<int> acc)
        {
            if (number == 1)
            {
                return acc;
            }
            if(number == D(D(number)) && D(number) != number)
            {
                return SearchAmicableNumbers(number - 1, acc.Concat(new[] {number}).ToList());
            }
            return SearchAmicableNumbers(number - 1, acc);
        }

        public int GetResult(int number)
        {
            return SearchAmicableNumbers(number,new List<int>()).Sum();
        }
            
    }
}
