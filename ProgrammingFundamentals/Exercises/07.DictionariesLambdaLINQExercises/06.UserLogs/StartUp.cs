namespace _06.UserLogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine().Trim();
            

            var usersIPs = new SortedDictionary<string, Dictionary<string, int>>();
            while (input!="end")
            {
                var log = input.Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
                var ipAdress = log[1];
                var userName = log[5];
                var couter = 1;
                if (!usersIPs.ContainsKey(userName))
                {
                    usersIPs.Add(userName, new Dictionary<string, int>());
                }
                if (!usersIPs[userName].ContainsKey(ipAdress))
                {
                    usersIPs[userName].Add(ipAdress, couter);
                }
                else
                {
                    usersIPs[userName][ipAdress]++;
                }
                input = Console.ReadLine();
            }
            foreach (var user in usersIPs)
            {
                Console.WriteLine($"{user.Key}:");
                foreach (var key in user.Value)
                {
                    if (key.Key!=user.Value.Keys.Last())
                    {
                        Console.Write($" {key.Key} => {key.Value},");
                    }
                    else
                    {
                        Console.Write($" {key.Key} => {key.Value}.");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
