namespace _06.StringsAndObjects
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string hello = "Hello";
            string world = "World";

            object concatenation = hello + " " + world;
            string typeCast = (string)concatenation;
            Console.WriteLine(typeCast);
        }
    }
}
