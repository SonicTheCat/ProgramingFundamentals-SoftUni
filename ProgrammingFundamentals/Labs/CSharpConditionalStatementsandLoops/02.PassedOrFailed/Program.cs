namespace _01.Passed
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            if (num >= 3)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
