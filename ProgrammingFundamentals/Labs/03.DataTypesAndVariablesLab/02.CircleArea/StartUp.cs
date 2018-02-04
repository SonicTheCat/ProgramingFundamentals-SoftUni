namespace _02.CircleArea
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"{radius*radius*Math.PI:F12}");
        }
    }
}
