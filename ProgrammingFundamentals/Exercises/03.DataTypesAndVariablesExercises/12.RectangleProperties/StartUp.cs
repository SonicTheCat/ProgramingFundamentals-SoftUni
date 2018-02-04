namespace _12.RectangleProperties
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height;
            double perim = (2 * width) + (2 * height);
            double diagonal1 = Math.Pow(width, 2);
            double diaglonal2 = Math.Pow(height, 2);
            double diagonal = diagonal1 + diaglonal2;

            Console.WriteLine(perim);
            Console.WriteLine(area);
            Console.WriteLine(Math.Sqrt(diagonal));
        }
    }
}
