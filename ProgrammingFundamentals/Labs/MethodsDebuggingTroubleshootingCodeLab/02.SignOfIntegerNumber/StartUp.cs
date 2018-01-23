namespace _02.SignOfIntegerNumber
{
    using System;

    public class StartUp
    {
        
        static void PositiveOrNegative(int n)
        {
            if (n>0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n<0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }

        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            PositiveOrNegative(num);
        }
    }
}
