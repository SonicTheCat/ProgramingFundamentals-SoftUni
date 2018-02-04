namespace _03.ExactSumOfRealNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0m;

            for (int i = 1; i <=n; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
