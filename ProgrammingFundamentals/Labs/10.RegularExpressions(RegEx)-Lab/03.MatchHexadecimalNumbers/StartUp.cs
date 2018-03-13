namespace _03.MatchHexadecimalNumbers
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var pattern = @"\b(?:0x)?[0-9A-F]+\b";
            var input = Console.ReadLine();

            var numbers = Regex.Matches(input, pattern)
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
