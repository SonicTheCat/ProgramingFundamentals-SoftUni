namespace _06FoldAndSum
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var k = numbers.Length / 4;

            var leftPart = numbers.Take(k).Reverse().ToArray();
            var rightPart = numbers.Skip(k*3).Take(k).Reverse().ToArray();
            var middle = numbers.Skip(k).Take(k * 2).ToArray();
            var concatSides = leftPart.Concat(rightPart).ToArray();
            for (int i = 0; i < concatSides.Length; i++)
            {
                Console.Write($"{concatSides[i] + middle[i]} ");
            }
            Console.WriteLine();
        }
    }
}
