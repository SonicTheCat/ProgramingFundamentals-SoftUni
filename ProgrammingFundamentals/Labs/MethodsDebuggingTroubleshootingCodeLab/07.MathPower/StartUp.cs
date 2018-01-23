namespace _07.MathPower
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(RaisedToPower(number,power));
        }

        static double RaisedToPower(double number, int power)
        {
            var result = 1d;
            for (int i = 0; i < power; i++)
            {
                result = result * number;
            }
            return result;
        }
    }
}
