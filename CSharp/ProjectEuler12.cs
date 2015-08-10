using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharp
{
    public class Euler12
    {

        private readonly List<long> _numbers;

        public Euler12()
        {
            _numbers = TriangularNumbersGenerator().ToList();
        }

        private IEnumerable<long> TriangularNumbersGenerator()
        {
            long x = 0;
            long y = 1;
            while (x < 765)
            {
                yield return x;
                x += y;
                y = y + 1;
            }
        }


        private List<long> GetFactors(long number, long first, List<long> acc)
        {
            if (first > (number / first) || first > (number / 2))
            {
                return acc;
            }
            else if (number % first == 0)
            {
                return GetFactors(number, first + 1, acc.Concat(new List<long>() {first,(number / first)}).ToList());
            }
            else
            {
                return GetFactors(number, first + 1, acc.Concat(Enumerable.Empty<long>()).ToList());
            }
        }
 
        private int CountFactors(long number)
        {
            return GetFactors(number, 1, new List<long>()).Distinct().Count();
        }


        private long CountFactorsImperative(long number)
        {
            long n = 1;
            int counter = 0;
            while (n <= number / 2)
            {
                if (number % n == 0)
                {
                    counter += 2;
                }
                n++;
            }
            return counter;
        }

        public long GetFirstNumber(int factorQuantity)
        {
            return _numbers.First(x => CountFactorsImperative(x) > 5);
        }
    }
}
