namespace _17.PrintPartASCIITable
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int fisrtChar = int.Parse(Console.ReadLine());
            int secondChar = int.Parse(Console.ReadLine());

            for (char i = Convert.ToChar(fisrtChar); i <= secondChar; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
