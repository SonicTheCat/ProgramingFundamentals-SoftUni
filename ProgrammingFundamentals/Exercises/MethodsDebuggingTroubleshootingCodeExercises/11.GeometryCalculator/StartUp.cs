namespace _11.GeometryCalculator
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string figureType = Console.ReadLine().ToLower();
            if (figureType== "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine(CalculateTriangleArea(side,height));
            }
            else if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine(CalculateSquareArea(side));
            }
            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine(CalculateRectangleArea(width, height));
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine(CalculateCircleArea(radius));
            }
        }

        static double CalculateTriangleArea(double side, double height)
        {
            double area = Math.Round((side * height) / 2,2);
            return area;
        }

        static double CalculateSquareArea(double side)
        {
            double area = Math.Round(side * side, 2);
            return area;
        }

        static double CalculateRectangleArea(double width,double height)
        {
            double area = Math.Round(width * height, 2);
            return area; 
        }

        static double CalculateCircleArea(double radius)
        {
            double area = Math.Round(Math.PI * radius*radius,2);
            return area;
        }
    }
}
