namespace _04.Elevator
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());

            Console.WriteLine($"{Math.Ceiling((double)capacity/people)}");


        }
    }
}
