using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharp
{
    public class Program
    {
        public static bool IsPrime(int number)
        {
            return Enumerable.Range(2, (int)Math.Sqrt(number)).Count(x=> number % x == 0) == 0;
        }

        public static IEnumerable<int> PrimeList()
        {
            int number = 2;
            while (true)
            {
                if (IsPrime(number))
                {
                    yield return number;
                }
                number++;
            }
        }

        static void Main(string[] args)
        {
            var a = PrimeList().Take(10001);

            Console.WriteLine(a.ToList()[10000]);
        }
    }
}
