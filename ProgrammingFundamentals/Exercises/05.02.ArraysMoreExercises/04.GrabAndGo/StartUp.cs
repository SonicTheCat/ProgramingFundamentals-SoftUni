namespace _03.SafeManipulation
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = long.Parse(Console.ReadLine());
            var count = 0;
            var flag = true;
            for (long i = numbers.Length - 1; i >= 0; i--)
            {
                count++;
                if (numbers[i] == n)
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                var sum = 0L;
                for (long i = 0; i < numbers.Length - count; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
