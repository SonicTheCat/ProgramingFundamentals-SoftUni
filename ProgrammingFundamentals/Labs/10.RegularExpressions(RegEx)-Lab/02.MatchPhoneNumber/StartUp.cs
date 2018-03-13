namespace _02.MatchPhoneNumber
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var pattern = @"\+359( |\-)2(\1)[0-9]{3}(\1)[0-9]{4}\b";
            var input = Console.ReadLine();

            MatchCollection matched = Regex.Matches(input, pattern);

            string[] phones = matched
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ",phones));
        }
    }
}
