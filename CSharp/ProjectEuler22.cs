using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestCSharp
{
    public class Euler22
    {

        public static List<string> NameList() => File.ReadAllLines(@"C:\Users\domin_000\Documents\Visual Studio 2015\Projects\TestCSharp\TestCSharp\Euler11.txt")[0].Split(',').ToList();

        private int SumLetterPositions(string word)
        {
            int result = 0;
            foreach (var item in word.ToCharArray())
            {
                int tmp;
                if (PositionsMap.TryGetValue(item, out tmp))
                {
                    result += tmp;
                }
            }
            return result;
        }

        public IEnumerable<int> GetResult(List<string> list)
        {
            for (int i = 0; i < list.Count(); i++)
            {
                yield return SumLetterPositions(list[i]) * (i+1);
            }
        }

        private Dictionary<char, int> DictGnerator()
        {
            var result = new Dictionary<char,int>();
            var alpha = "\"ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for (int i = 0; i < alpha.Length; i++)
            {
                result.Add(alpha[i],i);
            }
            return result;
        }

        public Dictionary<char, int> PositionsMap => DictGnerator();
    }
}
