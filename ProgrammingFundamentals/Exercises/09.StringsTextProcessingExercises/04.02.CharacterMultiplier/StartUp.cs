namespace _04._02.CharacterMultiplier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            List<char> firstHalf = input[0].ToList();
            List<char> secondHalf = input[1].ToList();
            var sum = 0;
            int shortest = Math.Min(firstHalf.Count, secondHalf.Count);
            List<char> longest = shortest == firstHalf.Count ? secondHalf : firstHalf;
            for (int i = 0; i < shortest; i++)
            {
                sum += firstHalf[i] * secondHalf[i];
                longest[i] = '0';
            }

            sum += longest.Where(x => x != '0').Sum(x => Convert.ToInt32(x));
            Console.WriteLine(sum);
        }
    }
}
