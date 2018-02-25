namespace _01.Convertfrombase10baseN
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(BigInteger.Parse).ToList();

            BigInteger toBase = input[0];
            BigInteger number = input[1];
            List<BigInteger> result = new List<BigInteger>();
            while (number != 0)
            {
                result.Add(number % toBase);
                number = number / toBase;
            }
            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}
