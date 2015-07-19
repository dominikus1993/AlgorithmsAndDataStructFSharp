using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestSC
{
    class Program
    {
        public static IEnumerable<long> FindFactor(long number)
        {
            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0 )
                {
                    yield return i;
                }    
            }
        }

        static bool IsPrime(long number)
        {
            return FindFactor(number).LongCount() == 0;
        }

        public static IEnumerable<long> Range(long start, long stop)
        {
            for (long i = 2; i < stop; i++)
            {
                yield return i;
            }
        } 

        static void Main(string[] args)
        {
            var number = 600851475143;
            var max = Range(2, (long)Math.Sqrt(number)).Where(x=>number % x == 0).Where(IsPrime).Max();
            Console.WriteLine(max);
        }
    }
}
