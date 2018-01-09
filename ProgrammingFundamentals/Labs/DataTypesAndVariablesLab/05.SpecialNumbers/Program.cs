namespace _05.SpecialNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n; i++)
            {
                int num1 = i % 10;            
                int num2 = i / 10;
              
                if (num1 + num2 == 5 || num1 + num2 == 7 || num1 + num2 == 11)
                    Console.WriteLine($"{i} -> True");
                else Console.WriteLine($"{i} -> False");
            }
        }
    }
}
