using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _01.ExtractEmails
{
    class StartUp
    {
        static void Main()
        {
            var pattern = @"(^| )[a-z0-9]+[a-z0-9.\-_]*@[a-z-]+(\.[a-z]+)+";

            var input = Console.ReadLine();

            var matched = Regex.Matches(input, pattern);

            foreach (Match match in matched)
            {
                Console.WriteLine(match.Value.Trim());
            }
        }
    }
}
