namespace _07._02.SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<Sale> totalSales = new List<Sale>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Sale currentSale = new Sale();
                currentSale.Town = input[0];
                currentSale.Product = input[1];
                currentSale.Price = double.Parse(input[2]);
                currentSale.Quantity = double.Parse(input[3]);

                totalSales.Add(currentSale);
            }
             List<string> towns = totalSales.Select(x=>x.Town).Distinct().OrderBy(x=>x).ToList();

            foreach (var town in towns)
            {
                double revenue = totalSales.Where(x => x.Town == town).Select(x => x.Revenue()).Sum();
                Console.WriteLine($"{town} -> {revenue:f2}");

            }
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
