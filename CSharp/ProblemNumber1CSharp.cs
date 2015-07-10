using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
           var list = Enumerable.Range(1, 100).ToImmutableList().Reverse().First();
            Console.WriteLine(list);
        }
    }
}
