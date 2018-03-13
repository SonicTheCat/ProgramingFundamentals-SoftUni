namespace _01.MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"\b[A-Z]{1}[a-z]{1,} [A-Z]{1}[a-z]{1,}\b";

            MatchCollection matched = Regex.Matches(input, pattern);

            foreach (var name in matched)
            {
                Console.Write(name+" ");
            }
            Console.WriteLine();
        }
    }
}
