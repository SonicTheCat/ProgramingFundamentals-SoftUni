namespace _08.CondenseArrayNumber
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (numbers.Length != 1)
            {
                int[] sumed = new int[numbers.Length - 1];
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    sumed[i] = numbers[i] + numbers[i + 1];
                }

                numbers = sumed;
            }
            if (numbers.Length == 1)
                Console.WriteLine($"{numbers[0]} is already condensed to number");
            else
                Console.WriteLine(numbers[0]);
        }
    }
}
