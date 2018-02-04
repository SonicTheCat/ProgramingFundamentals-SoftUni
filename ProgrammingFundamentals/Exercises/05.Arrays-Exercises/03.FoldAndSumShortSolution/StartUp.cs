namespace _03.FoldAndSumShortSolution
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int k = numbers.Length / 4;
            int[] leftArray = numbers.Take(k).ToArray();
            int[] rightArray = numbers.Skip(k*3).Take(k).ToArray();
            int[] middleArray = numbers.Skip(k).Take(k * 2).ToArray();

            Array.Reverse(leftArray);
            Array.Reverse(rightArray);

            int[] result = new int[k * 2];

            for (int i = 0; i < k; i++)
            {
                result[i] = leftArray[i] + middleArray[i];
                result[k+i] = rightArray[i] + middleArray[k+i];
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
