namespace _04.Numbers_in_Reversed_Order
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            Console.WriteLine(ReversedNumber(number));
        }

        static string ReversedNumber(string number)
        {
            string result = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                result += number[i];      
            }
            return result;
        }
    }
}
////namespace _05.NumberInReversedOrder
//{
//    using System;
//    using System.Linq;

//    public class StartUp
//    {
//        public static void Main()
//        {
//            var number = 12.1;

//            var result = number.ToString().Reverse();

//            foreach (var symbol in result)
//            {
//                Console.Write(symbol);
//            }
//        }
//    }
//}
