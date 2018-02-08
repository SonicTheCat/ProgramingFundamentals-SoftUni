namespace _04.SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<string> words = Console.ReadLine()
                .Split(new char[] { ';', ' ', ':', ',', '.', '!', '(', ')', '\\', '/', '\"', '\'', '[', ']' },StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> lowerCaseLetters = new List<string>();
            List<string> upperCaseLetters = new List<string>();
            List<string> mixedCaseLetters = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                string letters = words[i];
                bool countUpper = false;
                bool countLower = false;
                foreach (var element in letters)
                {
                    if (element>=65&&element<=90)
                    {
                        countUpper = true;
                    }
                    else if (element>=97&&element<=122)
                    {
                        countLower = true;
                    }
                    else
                    {
                        countUpper = true;
                        countLower = true;
                    }
                }
                if (countUpper && !countLower)
                {
                    upperCaseLetters.Add(words[i]);
                }
                if (!countUpper && countLower)
                {
                    lowerCaseLetters.Add(words[i]);
                }
                if (countUpper && countLower)
                {
                    mixedCaseLetters.Add(words[i]);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ",lowerCaseLetters)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ",mixedCaseLetters)}");
            Console.WriteLine($"Upper-case: {string.Join(", ",upperCaseLetters)}");
        }
    }
}
