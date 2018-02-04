namespace _01.HelloName
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            PrintName(name);

        }
        static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
