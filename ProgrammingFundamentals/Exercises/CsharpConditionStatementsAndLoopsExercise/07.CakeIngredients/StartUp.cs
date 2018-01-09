namespace _07.CakeIngredients
{
    using System;

   public class StartUp
    {
        public static void Main()
        {
            int count = 0;

            while (true)
            {
                string ingredient = Console.ReadLine();
                if (ingredient=="Bake!")
                {
                    break;
                }
                Console.WriteLine($"Adding ingredient {ingredient}.");
                count++;
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
