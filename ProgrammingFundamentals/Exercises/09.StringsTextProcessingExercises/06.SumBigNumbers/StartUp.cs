namespace _06.SumBigNumbers
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (first.Length > second.Length)
            {
                second = second.PadLeft(first.Length, '0');
            }
            else
            {
                first = first.PadLeft(second.Length, '0');
            }
            List<int> result = new List<int>();

            var reminder = 0;
            for (int i = first.Length - 1; i >= 0; i--)
            {
                var currentResult = 0;

                int numOne = first[i] - 48;
                int numTwo = second[i] - 48;
                currentResult = numOne + numTwo + reminder;
                result.Add(currentResult % 10);
                reminder = currentResult / 10;

                if (i == 0 && reminder > 0)
                {
                    result.Add(reminder);
                }
            }

            result.Reverse();
            string print = string.Join("", result);
            Console.WriteLine(print.TrimStart('0'));
        }
    }
}
