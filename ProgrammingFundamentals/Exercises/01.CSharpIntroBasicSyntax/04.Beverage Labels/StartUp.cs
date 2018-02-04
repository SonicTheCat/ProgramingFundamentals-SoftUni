namespace _04.Beverage_Labels
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string product = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double energyPerProduct = (volume * energy) / 100;
            double sugarPerProduct = (volume * sugar) / 100;

            Console.WriteLine($"{volume}ml {product}:");
            Console.WriteLine($"{energyPerProduct}kcal, {sugarPerProduct}g sugars");
        }
    }
}
