namespace _05.MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {List<string> input = Console.ReadLine().Split(new char[] { ' ', '\t' },
               StringSplitOptions.RemoveEmptyEntries)
           .Select(x => x.Trim())
           .ToList();
             
            Dictionary<char, char> representation = new Dictionary<char, char>();

            var firstWord = input[0].ToCharArray();
            var secondWord = input[1].ToCharArray();
            var shorter = Math.Min(firstWord.Length, secondWord.Length);

            var shorterWord = shorter == firstWord.Length ? firstWord : secondWord;
            var longerWord = shorter == firstWord.Length ? secondWord : firstWord;

            for (int i = 0; i < shorter; i++)
            {
                if (!representation.ContainsKey(shorterWord[i]))
                {
                    if (representation.ContainsValue(longerWord[i]))
                    {
                        Console.WriteLine("false");
                        return;
                    }
                    representation.Add(shorterWord[i], longerWord[i]);
                }
 
                if (representation[shorterWord[i]] == longerWord[i])
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("false");
                    return;
                }
            }

            if (firstWord.Length != secondWord.Length)
            {
                for (int i = longerWord.Length - 1; i > shorterWord.Length; i--)
                {
                    if (representation.ContainsValue(longerWord[i]))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }
            Console.WriteLine("true");
        }
    }
}
