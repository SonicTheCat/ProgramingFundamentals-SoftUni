namespace _06.PrimeChecker
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(isPrime(number));
        } 
        static bool isPrime (long number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i <=Math.Sqrt(number); i++)
            {    
                if (number%i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
