namespace _14.IntegerToHexAndBinary
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string hexaFormat = Convert.ToString(number, 16).ToUpper();
            string binFormat = Convert.ToString(number, 2);
            Console.WriteLine(hexaFormat);
            Console.WriteLine(binFormat);
        }
    }
}
