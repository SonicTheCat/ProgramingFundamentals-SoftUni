namespace _08.LettersChangeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ', '\t' },
               StringSplitOptions.RemoveEmptyEntries)
           .Select(x => x.Trim())
           .ToList();

            decimal sum = 0m;

            for (int i = 0; i < input.Count; i++)
            {
                string word = input[i];
                char firstLetter = word.First();
                char lastLetter = word.Last();
                string remove = word.Remove(0, 1);
                remove = remove.Remove(remove.Length - 1, 1);
                decimal number = decimal.Parse(remove);

                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    int postion = FindLetterPosition(firstLetter);
                    number = number / postion;
                }
                else
                {
                    int position = FindLetterPosition(firstLetter);
                    number = number * position;
                }

                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    int position = FindLetterPosition(lastLetter);
                    number = number - position;
                }
                else
                {
                    int position = FindLetterPosition(lastLetter);
                    number = number + position;
                }
                sum += number;
            }

            Console.WriteLine($"{sum:F2}");
        }

        private static int FindLetterPosition(char position)
        {
            var startIndex = position < 97 ? 'A' : 'a';
            int count = 0;

            for (char i = startIndex; i <= position; i++)
            {
                count++;
            }
            return count;
        }
    }
}
