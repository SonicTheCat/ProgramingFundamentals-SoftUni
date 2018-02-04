namespace _01.DebitCardNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNum:d4} {secondNum:d4} {thirdNum:d4} {fourthNum:d4}");
        }

    }
}
