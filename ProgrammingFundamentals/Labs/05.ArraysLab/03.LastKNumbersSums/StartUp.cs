namespace _03.LastKNumbersSums
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] array = new long[n];
            array[0] = 1;
            for (long i = 1; i < array.Length; i++)
            {
                long start = Math.Max(0, i - k);
                var sum = 0l;
                for (long j = start; j <=i-1; j++)
                {
                    sum += array[j];
                }
                array[i] = sum;
            }

            for (long i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+ " ");
            }

            Console.WriteLine();
        }
    }
}
