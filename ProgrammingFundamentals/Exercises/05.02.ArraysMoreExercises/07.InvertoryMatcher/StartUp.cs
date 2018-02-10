namespace _07.InvertoryMatcher
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] nameOfProduct = Console.ReadLine().Split();
            long[] quantityOfProduct = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();
            decimal[] priceOfProduct = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToArray();

            string newProduct = Console.ReadLine();
            while (newProduct!="done")
            {
                FindingProduct(newProduct, nameOfProduct, quantityOfProduct, priceOfProduct);
                newProduct = Console.ReadLine();
            }
        }
        
        static void FindingProduct(string newProduct, string[] nameOfProduct, long[] quantityOfProduct, decimal[] priceOfProduct)
        {
            for (int i = 0; i < nameOfProduct.Length; i++)
            {
                if (newProduct==nameOfProduct[i])
                {
                    Console.WriteLine($"{nameOfProduct[i]} costs: {priceOfProduct[i]}; Available quantity: {quantityOfProduct[i]}");
                    break;
                }
            }
        }
    }
}
