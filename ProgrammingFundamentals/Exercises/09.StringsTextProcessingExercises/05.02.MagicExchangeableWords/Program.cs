namespace _05._02.MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            List<char> firstArr = input[0].ToCharArray().Distinct().ToList();
            List<char> secondArr = input[1].ToCharArray().Distinct().ToList();
            bool exchengable = firstArr.Count == secondArr.Count;

            Console.WriteLine(exchengable.ToString().ToLower());
        }
    }
}
