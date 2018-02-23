namespace _03.BigFactorial
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 1; i <=n; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }
    }
}
