namespace _02.ConvertFrombaseNbase10
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            BigInteger[] input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            BigInteger toBase = (BigInteger)input[0];
            BigInteger number = input[1];
            BigInteger result = 0;
            BigInteger power = 0;


            while (number!=0)
            {
                BigInteger lagstDigit = number % 10;
                BigInteger baseToPower = 1;

                if (power==0)
                {
                    baseToPower = 1;
                }
                else
                {
                    for (int i = 0; i < power; i++)
                    {
                        baseToPower *= toBase;
                    }
                }

                result += baseToPower * lagstDigit;
                number = number / 10;
                power++;
            }
             
            Console.WriteLine(result);
        }
    }
}
