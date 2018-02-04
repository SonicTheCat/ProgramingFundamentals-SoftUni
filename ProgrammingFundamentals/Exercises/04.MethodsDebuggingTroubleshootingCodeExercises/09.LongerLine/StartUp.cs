namespace _09.LongerLine
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double pointOneX1 = double.Parse(Console.ReadLine());
            double pointOneY1= double.Parse(Console.ReadLine());
            double pointOneX2 = double.Parse(Console.ReadLine());
            double pointOneY2 = double.Parse(Console.ReadLine());

            double pointTwoX1 = double.Parse(Console.ReadLine());
            double pointTwoY1 = double.Parse(Console.ReadLine());
            double pointTwoX2 = double.Parse(Console.ReadLine());
            double pointTwoY2 = double.Parse(Console.ReadLine());

            double first = GetLineSize(pointOneX1, pointOneY1, pointOneX2, pointOneY2);
            double second = GetLineSize(pointTwoX1, pointTwoY1, pointTwoX2, pointTwoY2);

            if (first>=second)
            {
                ClosestToZero(pointOneX1, pointOneY1, pointOneX2, pointOneY2);
            }
            else
            {
                ClosestToZero(pointTwoX1, pointTwoY1, pointTwoX2, pointTwoY2);
            }
        }

        static double GetLineSize(double x1,double y1, double x2, double y2)
        {
            double sum = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return sum;
        }
        
        static void ClosestToZero(double x1, double y1, double x2, double y2)
        {
            double firstPoint = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2));
            double secondPoint = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2));

            if (firstPoint <= secondPoint)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}
