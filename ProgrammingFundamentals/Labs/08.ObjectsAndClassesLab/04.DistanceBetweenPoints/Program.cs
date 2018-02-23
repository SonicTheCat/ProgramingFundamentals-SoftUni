using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DistanceBetweenPoints
{
    class Program
    {
        class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }

        static void Main(string[] args)
        {
            int[] first  = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point firstPoint = new Point { X = first[0], Y = first[1] };
            Point secondPoint = new Point { X = second[0], Y = second[1] };

            var distance = CalcDistanceTwoPoints(firstPoint, secondPoint);

            Console.WriteLine($"{distance:F3}");
        }
        static double CalcDistanceTwoPoints(Point firstPoint, Point secondPoint)
        {
            return Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2));
        }
    }
}
