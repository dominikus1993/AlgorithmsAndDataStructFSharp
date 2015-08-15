 public class Euler15
    {

        public static BigInteger Factorial(int n)
        {
            var factorials = new BigInteger[n + 1];
            factorials[0] = 1;
            for (int i = 1; i <= n; i++)
            {
                factorials[i] = factorials[i - 1] * i;
            }
            return factorials.Last();
        }

        public static BigInteger Combination(int n, int k)
        {
           return Factorial(n)/(Factorial(k)*Factorial(n - k));
        }
    }
