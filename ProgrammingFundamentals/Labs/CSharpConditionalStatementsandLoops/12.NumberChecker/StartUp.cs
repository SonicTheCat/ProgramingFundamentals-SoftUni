namespace _12.NumberChecker
{
    using System;

    public class StartUp
    {
        public static void Main()
        {    
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch 
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
