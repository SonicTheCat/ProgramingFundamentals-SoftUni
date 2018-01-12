namespace _16.ComparingFloats
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double fistNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double biggerNum = Math.Max(fistNumber, secondNumber);
            double smallerNum = Math.Min(fistNumber, secondNumber);
            double result = biggerNum - smallerNum;

            if (result < 0.000001)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
