namespace _14.FactorialTrailingZeroes
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(FindFactorial(number));
        }

        static BigInteger FindFactorial(int number)
        {
            BigInteger fact = 1;
            for (int i = number; i >=1; i--)
            {
                fact *= i;
            }

            return TrailingZeroesInFactorial(fact);  
        }

        static int TrailingZeroesInFactorial(BigInteger fact)
        {
            string factorial = fact.ToString();
            var count = 0;
            for (int i = factorial.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(factorial[i].ToString());
                if (digit == 0)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }
}
