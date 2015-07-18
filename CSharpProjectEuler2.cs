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
        public static IEnumerable<int> FibSeq()
        {
            int firstNumber = 1;
            int secondNumber = 0;
            
            yield return secondNumber;

            while (firstNumber < 40000000)
            {
                yield return firstNumber;
                int tmp = firstNumber;
                firstNumber += secondNumber;
                secondNumber = tmp;
            }
        }
        static void Main(string[] args)
        {
            var sum = FibSeq().Where(x=>x % 2 == 0).Sum(); 

            Console.WriteLine(sum);
        }
    }
}
