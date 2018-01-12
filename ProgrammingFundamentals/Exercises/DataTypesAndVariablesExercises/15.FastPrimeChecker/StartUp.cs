namespace _15.FastPrimeChecker
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int range = int.Parse(Console.ReadLine());

            for (int i = 2; i <= range; i++)
            {
                bool prime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                    }
                }
                Console.WriteLine($"{i} -> {prime}");
            }
        }
    }
}
