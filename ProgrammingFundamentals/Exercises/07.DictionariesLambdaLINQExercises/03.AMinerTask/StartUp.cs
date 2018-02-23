namespace _03.AMinerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string resource = Console.ReadLine();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            while (resource != "stop")
            {
                int quantitie = int.Parse(Console.ReadLine());
                if (dict.ContainsKey(resource))
                {
                    dict[resource] += quantitie;
                }
                else
                {
                    dict[resource] = quantitie;
                }
                resource = Console.ReadLine();
            }
            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
