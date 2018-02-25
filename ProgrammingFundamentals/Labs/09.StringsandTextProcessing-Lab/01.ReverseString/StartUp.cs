namespace _01.ReverseString
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(String.Join("", arr));
        }
    }
}
