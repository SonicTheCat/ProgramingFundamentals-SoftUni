namespace _02.OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .ToLower()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var words = new Dictionary<string, int>();
            foreach (var element in input)
            {
                if (words.ContainsKey(element))
                {
                    words[element]++;
                }
                else
                {
                    words[element] = 1;
                }
            }
            var list = new List<string>();
            foreach (var pair in words)
            {
                if (pair.Value%2!=0)
                {
                    list.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", ",list));
        }
    }
}
