namespace _02.AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<string> countOfLists = Console.ReadLine().Split('|').ToList();
            var reversed = new List<int>();
            for (int i = countOfLists.Count-1; i>=0; i--)
            {
                List<int> numbers = countOfLists[i]
                      .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                      .Select(int.Parse)
                      .ToList();

                foreach (var element in numbers)
                {
                    reversed.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ",reversed));
        }
    }
}
