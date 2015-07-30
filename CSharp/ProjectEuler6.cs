using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharp
{
    public class Program
    {
        private static Func<int, Func<int, int>, int> sumNumbers = (x, func) => Enumerable.Range(1, x).Sum(func);


        static void Main(string[] args)
        {
            var sumSquares = sumNumbers(20, x => x * x);
            var squaresSum = Math.Pow(sumNumbers(20, x => x), 2);
            Console.WriteLine(squaresSum - sumSquares);
        }
    }
}
