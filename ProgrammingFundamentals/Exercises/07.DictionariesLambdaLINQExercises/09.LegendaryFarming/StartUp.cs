namespace _09.LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var materialsQunatity = new Dictionary<string, int>()
            {
                ["motes"] = 0,
                ["fragments"] = 0,
                ["shards"] = 0
            };
            var junkQuantity = new Dictionary<string, int>();
            var lessThan250 = true;
            var obtainedItem = "";
            while (lessThan250)
            {
                var input = Console.ReadLine()
                .ToLower()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                while (input.Count > 0 && lessThan250)
                {
                    var count = int.Parse(input[0]);
                    if (materialsQunatity.ContainsKey(input[1]))
                    {
                            materialsQunatity[input[1]] += count;
                    }
                    else
                    {
                        if (!junkQuantity.ContainsKey(input[1]))
                        {
                            junkQuantity.Add(input[1], count);
                        }
                        else
                        {
                            junkQuantity[input[1]] += count;
                        }
                    }
                    
                    foreach (var pair in materialsQunatity)
                    {
                        if (pair.Value >= 250)
                        {
                            lessThan250 = false;
                            if (pair.Key == "fragments") obtainedItem = "Valanyr";
                            else if (pair.Key == "shards") obtainedItem = "Shadowmourne";
                            else if (pair.Key == "motes") obtainedItem = "Dragonwrath";
                            Console.WriteLine($"{obtainedItem} obtained!");
                            materialsQunatity[pair.Key] -= 250;
                            break;
                        }
                    }
                    input.RemoveAt(0);
                    input.RemoveAt(0);
                }
            }

            foreach (var pair in materialsQunatity.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            foreach (var pair in junkQuantity.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
