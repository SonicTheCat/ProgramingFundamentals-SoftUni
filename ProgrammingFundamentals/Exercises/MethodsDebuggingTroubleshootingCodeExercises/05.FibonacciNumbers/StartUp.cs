namespace _05.FibonacciNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(FibunaciNumber(number));
        }
        static int FibunaciNumber(int number)
        {          
            var fibNum = 1;
            var prevNum = 0;
            for (int i = 0; i < number; i++)
            {
                int oldFib = fibNum;
                fibNum = fibNum + prevNum;
                prevNum = oldFib;
            }
            return fibNum;
        }
    }
}
