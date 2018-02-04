namespace _11.OddNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {          
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                num = Math.Abs(num);
                if (num%2==1)
                {
                    Console.WriteLine($"The number is: {num}");
                    break;
                }
                else
                    Console.WriteLine($"Please write an odd number.");
            }
        }
    }
}
