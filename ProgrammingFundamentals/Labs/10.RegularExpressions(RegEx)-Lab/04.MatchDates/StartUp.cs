namespace _04.MatchDates
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string pattern = @"\b(?<day>\d{2})(\/|\.|\-)(?<month>[A-Z]{1}[a-z]{2})\1(?<year>\d{4})\b";

            var inputDates = Console.ReadLine();

            MatchCollection matched = Regex.Matches(inputDates, pattern);

            foreach (Match match in matched)
            {
                var day = match.Groups["day"].Value;
                var month = match.Groups["month"].Value;
                var year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
