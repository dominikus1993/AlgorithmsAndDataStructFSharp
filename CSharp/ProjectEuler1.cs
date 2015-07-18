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
        static void Main(string[] args)
        {
            var sum = Enumerable.Range(1, 1000 - 1).Where(x => x % 5 == 0 || x % 3 == 0).Sum();
            Console.WriteLine(sum);
        }
    }
}
