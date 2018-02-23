namespace _08.LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var infoLogsIn= new SortedDictionary<string, SortedDictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                string IP= input[0];
                string name = input[1];
                int duration = int.Parse(input[2]);

                if (!infoLogsIn.ContainsKey(name))
                {
                    infoLogsIn.Add(name, new SortedDictionary<string, int>());
                    infoLogsIn[name].Add(IP, duration);
                }
                else if (!infoLogsIn[name].ContainsKey(IP))
                {
                    infoLogsIn[name].Add(IP, duration);
                }
                else
                {
                    infoLogsIn[name][IP] += duration;
                }
            }
            foreach (var pair in infoLogsIn)
            {
                var username = pair.Key;
                var IPS = pair.Value.Keys.ToList();
                var sum = pair.Value.Values.Sum();
              
                Console.Write($"{username}: {sum} [{string.Join(", ", IPS)}]");
                Console.WriteLine();
            }
        }
    }
}
