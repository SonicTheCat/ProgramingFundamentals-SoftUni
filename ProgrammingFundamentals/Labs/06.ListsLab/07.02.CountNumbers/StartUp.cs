namespace _07._02.CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var max = numbers.Max();
            int[] nums = new int[max+1];

            foreach (var element in numbers)
            {
                nums[element]++;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]!=0)
                {
                    Console.WriteLine($"{i} -> {nums[i]} ");
                }
            }
        }
    }
}
