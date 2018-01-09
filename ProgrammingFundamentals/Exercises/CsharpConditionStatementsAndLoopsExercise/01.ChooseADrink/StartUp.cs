namespace _01.ChooseADrink
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string profession = Console.ReadLine();
            string drink = "Tea";
            switch (profession)
            {
                case "Athlete": drink = "Water"; break;
                case "Businessman":
                case "Businesswoman": drink= "Coffee";break;
                case "SoftUni Student": drink="Beer";break;
            }
            Console.WriteLine(drink);
        }
    }
}
