namespace _09.MultiplicationTable
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int mult = int.Parse(Console.ReadLine());

            if (mult > 10)
                Console.WriteLine($"{num} X {mult} = {num * mult}");
            for (int i = mult; i <= 10; i++)
                Console.WriteLine($"{num} X {i} = {num * i}");         
        }
    }
}
