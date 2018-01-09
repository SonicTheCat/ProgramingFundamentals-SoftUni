namespace _06.IntervalOfNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int first = Math.Max(a, b);
            int second = Math.Min(a, b);

            for (int i = second; i <= first; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
