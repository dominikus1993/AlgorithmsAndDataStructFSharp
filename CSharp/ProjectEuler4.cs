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
         
        public static IEnumerable<int> ListGen(int start,int stop)
        {
            for (int i = start; i < stop; i++)
            {
                for (int j = start; j < stop; j++)
                {
                    yield return i * j;
                }
            }
        }

        static void Main(string[] args)
        {
            var result = ListGen(100, 900).Where(x => x.ToString() == string.Join("", x.ToString().ToCharArray().Reverse())).Max();
            Console.WriteLine(result);
        }
    }
}
