using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharp
{
    public class Program
    {

        public static Func<int, IEnumerable<int>, bool> isDevided = (number, numbers) => numbers.All(x => {return  number % x == 0; });
         
        static void Main(string[] args)
        {
            var list = Enumerable.Range(2, 19);

            Console.WriteLine(Enumerable.Range(2560,int.MaxValue - 10000).First(x=>isDevided(x,list)));
        }
    }
}
