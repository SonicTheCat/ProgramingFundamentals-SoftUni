namespace _01.ChooseADrink
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            string drink = "Tea";
            switch (profession)
            {
                case "Athlete": quantity *= 0.70; drink = "Water"; break;
                case "Businessman":
                case "Businesswoman": quantity *= 1.00; drink = "Coffee"; break;
                case "SoftUni Student": quantity *= 1.70; drink = "Beer"; break;
                default: quantity *= 1.20; break;
            }
            Console.WriteLine($"The {profession} has to pay {quantity:f2}.");
        }
    }
}
