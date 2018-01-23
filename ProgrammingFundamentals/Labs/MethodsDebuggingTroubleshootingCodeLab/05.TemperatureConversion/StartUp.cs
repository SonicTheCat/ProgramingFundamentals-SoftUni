namespace _05.TemperatureConversion
{
    using System;

    public class StartUp
    {
        static double FahrenheitToCelsium(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        public static void Main()
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsium = FahrenheitToCelsium(fahrenheit);
            Console.WriteLine($"{celsium:f2}");
        }
    }
}
