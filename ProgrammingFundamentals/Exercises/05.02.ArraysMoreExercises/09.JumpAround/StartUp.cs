namespace _09.JumpAround
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> addNums = new List<int>();
            var count = 0;
            addNums.Add(numbers[count]);

            while (count!=-1)
            {

                if (numbers[count] + count < numbers.Count)
                {
                    addNums.Add(numbers[count + numbers[count]]);
                    count += numbers[count];
                }
                else if (count - numbers[count]>= 0)
                {
                    addNums.Add(numbers[count - numbers[count]]);
                    count -= numbers[count];
                }
                else
                {
                    count = -1;
                }
            }

            Console.WriteLine(addNums.Sum());
        }
    }
}
