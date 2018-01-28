namespace _13.Factorial
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
            for (int i = number; i >= 1; i--)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
