﻿namespace _05.CompareCharArrays
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            char[] textOne = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] textTwo = Console.ReadLine().Split().Select(char.Parse).ToArray();
            var shorter = Math.Min(textOne.Length, textTwo.Length);
            string connectFirst = string.Join("", textOne);
            string connectSecond = string.Join("", textTwo);

            for (int i = 0; i < shorter; i++)
            {
                if (textOne[i]==textTwo[i]&&textOne.Length!=textTwo.Length)
                {
                    Console.WriteLine
                        (textOne.Length > textTwo.Length ? connectSecond : connectFirst);
                    Console.WriteLine
                        (textOne.Length > textTwo.Length ? connectFirst : connectSecond);
                    return;
                }
                else if (textOne[i] == textTwo[i])
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(textOne[i]>textTwo[i]? connectSecond : connectFirst);
                    Console.WriteLine(textOne[i]>textTwo[i]? connectFirst : connectSecond);
                    return;
                }
            }
            Console.WriteLine(connectFirst);
            Console.WriteLine(connectFirst);
        }
    }
}
