namespace _01.RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var positiveNums = new List<int>();
            bool found = false;
            for (int i = numbers.Count-1; i >= 0 ; i--)
            {
                if (numbers[i]>=0)
                {
                    positiveNums.Add(numbers[i]);
                    found = true;
                }
            }
            if (found)
            {
                Console.WriteLine(string.Join(" ", positiveNums));
            }
            else
            {
                Console.WriteLine("empty");
            } 
        }
    }
}
