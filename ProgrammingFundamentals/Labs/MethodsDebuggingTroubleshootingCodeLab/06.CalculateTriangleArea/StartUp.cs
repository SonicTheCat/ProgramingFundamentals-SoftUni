namespace _06.CalculateTriangleArea
{
    using System;

    public class StartUp
    {
        static double TriangleArea(double height, double width)
        {
            return height * width / 2;
        }
        public static void Main()
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double area = TriangleArea(height,width);
            Console.WriteLine(area);
        }
    }
}
