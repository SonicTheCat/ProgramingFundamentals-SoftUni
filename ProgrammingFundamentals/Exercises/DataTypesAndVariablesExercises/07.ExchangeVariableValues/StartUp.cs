namespace _07.ExchangeVariableValues
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before:");
            Console.WriteLine("a = "+a);
            Console.WriteLine("b = "+b);
            int oldA = 5;
            a = b;
            b = oldA;
            Console.WriteLine("After:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            
        }
    }
}
