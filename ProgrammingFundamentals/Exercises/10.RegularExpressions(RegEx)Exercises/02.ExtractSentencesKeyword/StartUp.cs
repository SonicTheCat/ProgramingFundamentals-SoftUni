namespace _02.ExtractSentencesKeyword
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {

            var keyWord = Console.ReadLine();
            var text = Console.ReadLine().Split(".!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var sentence in text)
            {
                var words = Regex.Split(sentence, @"[^A-Za-z0-9]+");
                foreach (var word in words)
                {
                    if (word == keyWord)
                    {
                        Console.WriteLine(sentence.Trim());
                        break;
                    }
                }
            }
        }
    }
}
