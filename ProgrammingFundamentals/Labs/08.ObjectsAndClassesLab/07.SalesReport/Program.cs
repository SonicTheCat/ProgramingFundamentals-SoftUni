namespace _07.SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var dictionary = new SortedDictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                Sale saleByTown = ReadSale();
                if (!dictionary.ContainsKey(saleByTown.Town))
                {
                    dictionary.Add(saleByTown.Town, saleByTown.Revenue());
                }
                else
                {
                    dictionary[saleByTown.Town] += saleByTown.Revenue();
                }
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:F2}");
            }
        }
        static Sale ReadSale()
        {
            var input = Console.ReadLine().Split().ToList();
            Sale saleByTown = new Sale();
            saleByTown.Town = input[0];
            saleByTown.Product = input[1];
            saleByTown.Price = double.Parse(input[2]);
            saleByTown.Quantity = double.Parse(input[3]);

            return saleByTown;
        }
    }

    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public double Revenue()
        {
            return this.Price * this.Quantity;
        }
    }
}
