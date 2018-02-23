namespace _10.СръбскоUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var concertInfo = new Dictionary<string, Dictionary<string, long>>();

            while (input != "End")
            {
 
                var splitInput = input.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);

           
                if (splitInput[0].Last()!=' ')
                {
                    input = Console.ReadLine();
                    continue;
                }
                var singerName = splitInput[0].Trim();
 
                var numsAndVenue = splitInput[1].Split(' ').ToList();
 
                long countOfTickets;
                long pricePerTicket;

                bool isNum1 = 
                    long.TryParse(numsAndVenue[numsAndVenue.Count - 1], out countOfTickets);
                bool isNum2 = 
                    long.TryParse(numsAndVenue[numsAndVenue.Count - 2], out pricePerTicket);
                if (!isNum1&&isNum2)
                {
                    input = Console.ReadLine();
                    continue;
                }
                numsAndVenue.RemoveAt(numsAndVenue.Count - 1);
                numsAndVenue.RemoveAt(numsAndVenue.Count - 1);

                string connect = string.Join(" ", numsAndVenue);
                string venue = connect;
  
                if (!concertInfo.ContainsKey(venue))
                {
                    concertInfo.Add(venue, new Dictionary<string, long>());
                    concertInfo[venue].Add(singerName, countOfTickets * pricePerTicket);
                }
                else if (!concertInfo[venue].ContainsKey(singerName))
                {
                    concertInfo[venue][singerName] = countOfTickets * pricePerTicket;
                }
                else
                {
                    concertInfo[venue][singerName] += countOfTickets * pricePerTicket;
                }
                input = Console.ReadLine();
            }
            foreach (var pair in concertInfo)
            {
                Console.WriteLine($"{pair.Key}");
                foreach (var kvp in pair.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
