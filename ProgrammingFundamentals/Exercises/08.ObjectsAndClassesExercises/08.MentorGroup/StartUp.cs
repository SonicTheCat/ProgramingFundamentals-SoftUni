namespace _08.MentorGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var allStudents = new Dictionary<string, Students>();
            while (input != "end of dates")
            {
                var splitInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = splitInput[0];

                List<string> date = new List<string>();
                if (splitInput.Length >= 2)
                {
                    date = splitInput[1].Split(',').ToList();
                }

                for (int i = 0; i < date.Count; i++)
                {
                    var currDate = date[i];

                    if (!allStudents.ContainsKey(name))
                    {
                        allStudents.Add(name, new Students());
                    }
                    if (!allStudents[name].DatesAtended.Contains(ConvertToDateTime(currDate)))
                    {
                        allStudents[name].DatesAtended.Add(ConvertToDateTime(currDate));
                    }
                    else
                    {
                        allStudents[name].DatesAtended.Add(ConvertToDateTime(currDate));
                    }
                }
                if (!allStudents.ContainsKey(name))
                {
                    allStudents.Add(name, new Students());
                }
                input = Console.ReadLine();
            }

            var secondInput = Console.ReadLine();
            while (secondInput != "end of comments")
            {
                var splitInput = secondInput.Split('-');
                var name = splitInput[0];
                var coment = splitInput[1];
                if (allStudents.ContainsKey(name))
                {
                    allStudents[name].Coments.Add(coment);
                }
                secondInput = Console.ReadLine();
            }

            PrintResult(allStudents);
        }

        private static void PrintResult(Dictionary<string, Students> allStudents)
        {
            foreach (var kvp in allStudents.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key}");
                Console.WriteLine("Comments:");
                foreach (var coment in kvp.Value.Coments)
                {
                    Console.WriteLine($"- {coment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in kvp.Value.DatesAtended.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {date:dd/MM/yyyy}");
                }
            }
        }

        private static DateTime ConvertToDateTime(string currDate)
        {
            var convert = DateTime.ParseExact(currDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            return convert;
        }
    }
    class Students
    {
        public List<DateTime> DatesAtended = new List<DateTime>();
        public List<string> Coments = new List<string>();

    }
}
