using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharp
{

    public class Euler9
    {
        private List<Tuple<int,int,int>> _triangles ;

        public Euler9()
        {
            _triangles = ListGeneartor().ToList();
        }

        private IEnumerable<Tuple<int, int, int>> ListGeneartor()
        {
            for (int i = 1; i <= 1000; i++)
            {
                for (int j = 1; j <= 1000; j++)
                {
                    for (int k = 1; k <= 1000; k++)
                    {
                        if (i + j + k == 1000)
                        {
                            yield return new Tuple<int, int, int>(i,j,k);
                        }
                    }
                }
            }
        }

        private bool IsPythagoreantriplet(Tuple<int, int, int> element)
        {
            int a = element.Item1;
            int b = element.Item2;
            int c = element.Item3;
            return a*a + b*b == c*c;
        }

        public int CalcProduct()
        {
            var result = _triangles.Where(IsPythagoreantriplet).First();
            return result.Item1 * result.Item2 * result.Item3;
        }
    }
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(new Euler9().CalcProduct());
        }
    }
}
