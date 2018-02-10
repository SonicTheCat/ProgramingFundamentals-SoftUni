namespace _01.ArrayStatistics
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int arrMin = numbers.First();
            int arrMax = numbers.Last();
            double arrSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (arrMax<numbers[i])
                {
                    arrMax = numbers[i];
                }
                if (arrMin>numbers[i])
                {
                    arrMin = numbers[i];
                }
                arrSum += numbers[i];
            }

            double arrAverage = arrSum / numbers.Length;
            Console.WriteLine($"Min = {arrMin}");
            Console.WriteLine($"Max = {arrMax}");
            Console.WriteLine($"Sum = {arrSum}");
            Console.WriteLine($"Average = {arrAverage}");
        }
    }
}
