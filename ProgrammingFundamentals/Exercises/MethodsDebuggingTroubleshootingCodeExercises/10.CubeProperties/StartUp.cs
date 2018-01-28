namespace _10.CubeProperties
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string shape = Console.ReadLine();
            Console.WriteLine("{0:f2}",GetCubeProperties(cubeSide,shape));
        }

        static double GetCubeProperties(double cubeSide, string shape)
        {
            double result = 0;
            if (shape == "face")
            {
                result = Math.Sqrt(Math.Pow(cubeSide, 2) + Math.Pow(cubeSide, 2));
            }
            else if (shape == "space")
            {
                result = Math.Sqrt(Math.Pow(cubeSide, 2) + Math.Pow(cubeSide, 2) +Math.Pow(cubeSide, 2));
            }
            else if (shape == "volume")
            {
                result = Math.Pow(cubeSide, 3);
            }
            else if (shape == "area")
            {
                double area = cubeSide * cubeSide;
                result = 6 * area;
            }
            return result;
        }
    }
}
