namespace _04Largest3Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var result= nums.OrderByDescending(n => n).Take(3);
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
