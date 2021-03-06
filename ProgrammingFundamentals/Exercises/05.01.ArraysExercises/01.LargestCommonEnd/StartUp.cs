﻿namespace _01.LargestCommonEnd
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] textOne = Console.ReadLine().Split();
            string[] textTwo = Console.ReadLine().Split();

            var result = CommonEndBetweenArrays(textOne, textTwo);
            Console.WriteLine(result);
        }

        static int CommonEndBetweenArrays(string[] textOne, string[] textTwo)
        {
            var smallerArr = Math.Min(textOne.Length, textTwo.Length);
            var countOne=0;
            var countTwo=0;
            for (int i = 0; i < smallerArr; i++)
            {
                if (textTwo[i]==textOne[i])
                {
                    countOne++;
                }
                else if (textOne[textOne.Length-1-i]==textTwo[textTwo.Length-1-i])
                {
                    countTwo++;
                }
            }

            var result = Math.Max(countOne, countTwo);
            return result;
        }
    }
}
