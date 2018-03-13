namespace _05.MatchNumbers
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            var input = Console.ReadLine();

            var matched = Regex.Matches(input, pattern);
            foreach (Match match in matched)
            {
                Console.Write(match.Value+ " ");
            }
            Console.WriteLine();
        }
    }
}
