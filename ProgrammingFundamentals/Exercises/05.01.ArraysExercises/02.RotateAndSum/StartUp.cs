namespace _02.RotateAndSum
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int countOfRotations = int.Parse(Console.ReadLine());

            int[] sum = RotateArrayElements(numbers, countOfRotations);
            Console.WriteLine(String.Join(" ",sum));
        }

        static int[] RotateArrayElements(int[] numbers, int countOfRotations)
        {
            var sum = new int[numbers.Length];
            for (int j = 0; j < countOfRotations; j++)
            {
                var lastDigit = numbers[numbers.Length - 1];
                for (int i = numbers.Length - 1; i > 0; i--)
                {
                    numbers[i] = numbers[i - 1];
                }
                numbers[0] = lastDigit;
                SumRotatedArrays(numbers,sum);
            }

            return sum;
        }

        static int[] SumRotatedArrays(int[] numbers, int[] sum)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                sum[i] += numbers[i];
            }

            return sum;
        } 
    }
}
