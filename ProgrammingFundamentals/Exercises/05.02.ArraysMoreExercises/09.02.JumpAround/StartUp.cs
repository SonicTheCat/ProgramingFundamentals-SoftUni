namespace _09._02.JumpAround
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                if (numbers[i] + i < numbers.Length)
                {
                    i += numbers[i] - 1;
                }
                else if (numbers[i] + i >= 0)
                {
                    i -= numbers[i] + 1;
                }
                if (i < 0 || i >= numbers.Length)
                {
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
