namespace _01.BlankReceipt
{
    using System;

    public class StartUp
    {
        static void HeaderReceipt()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");

        }
        static void BodyOfTheReceipt()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void BottomOfTheReceipt()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }
        static void PrintWholeReceipt()
        {
            HeaderReceipt();
            BodyOfTheReceipt();
            BottomOfTheReceipt();
        }
        public static void Main()
        {
            PrintWholeReceipt();
        }
      
    }
}

