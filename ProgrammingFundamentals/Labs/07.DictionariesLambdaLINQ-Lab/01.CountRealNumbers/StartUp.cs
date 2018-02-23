namespace _01.CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var count = new SortedDictionary<double, int>();
            foreach (var element in nums)
            {
                if (count.ContainsKey(element))
                {
                    count[element]++;
                }
                else
                {
                    count[element] = 1;
                }
            }
            foreach (var element in count)
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }
            
        }
    }
}
