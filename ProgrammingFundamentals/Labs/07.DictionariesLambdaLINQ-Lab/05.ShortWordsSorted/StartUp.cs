namespace _05.ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToArray();

            List<string> result = words.Where(x => x.Length < 5).OrderBy(x=>x).ToList();
            Console.WriteLine(string.Join(", ",result));

            
        }
    }
}
