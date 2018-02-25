namespace _04.Palindromes
{
    using System.Collections.Generic;
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> palindrome = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                char[] word = input[i].ToCharArray().Reverse().ToArray();
                string reversed = string.Join("", word);
                if (reversed == input[i])
                {
                    palindrome.Add(reversed);
                }
            }

            Console.WriteLine(string.Join(", ", palindrome.Distinct().OrderBy(x => x)));
        }
    }
}
