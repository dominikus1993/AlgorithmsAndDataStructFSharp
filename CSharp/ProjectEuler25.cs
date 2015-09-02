using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace TestCSharp
{
    public static class Euler25
    {
        public static IEnumerable<BigInteger> FibSeq()
        {
            BigInteger firstNumber = 1;
            BigInteger secondNumber = 0;

            yield return secondNumber;

            while (true)
            {
                yield return firstNumber;
                BigInteger tmp = firstNumber;
                firstNumber += secondNumber;
                secondNumber = tmp;
            }
        }

        public static int GetIndexBinderFibElement(int countNumber)
            => FibSeq().TakeWhile(x => x.ToString().ToCharArray().Length != countNumber).ToArray().Length;
    }
}
