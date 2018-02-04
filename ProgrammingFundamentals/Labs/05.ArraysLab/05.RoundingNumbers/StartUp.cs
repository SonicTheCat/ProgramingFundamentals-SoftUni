namespace _05.RoundingNumbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string realNums = Console.ReadLine();

            double[] numbers = realNums.Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
