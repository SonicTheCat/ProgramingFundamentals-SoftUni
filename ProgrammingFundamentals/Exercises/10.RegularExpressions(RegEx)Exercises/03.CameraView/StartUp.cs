using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.CameraView
{
    public class StartUp
    {
        public static void Main()
        {
            var integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string pattern = @"\|<(.*?)(?=\||$)";
            var text = Console.ReadLine();
            List<string> result = new List<string>();
            MatchCollection matched = Regex.Matches(text, pattern);

            foreach (Match match in matched)
            {
                char[] elements = match.Groups[1].ToString().Skip(integers[0]).Take(integers[1]).ToArray();
                string joinElements = string.Concat(elements);
                result.Add(joinElements);
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
