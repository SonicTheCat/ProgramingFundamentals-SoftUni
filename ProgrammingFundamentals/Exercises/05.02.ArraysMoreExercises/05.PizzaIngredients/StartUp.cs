namespace _05.PizzaIngredients
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] ingredients = Console.ReadLine().Split();
            long maxLenth = long.Parse(Console.ReadLine());
            var count = 0;
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Length == maxLenth)
                {
                    count++;
                    Console.WriteLine($"Adding {ingredients[i]}.");
                }
                if (count >= 10)
                {
                    break;
                }
            }

            string[] addedIngredients = new string[count];
            for (int j = 0, i = 0; j < ingredients.Length; j++)
            {
                if (ingredients[j].Length == maxLenth)
                {
                    addedIngredients[i] = ingredients[j];
                    i++;
                }
                if (i==addedIngredients.Length)
                {
                    break;
                }
            }
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", addedIngredients)}.");
        }
    }
}
