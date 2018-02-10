namespace _05.PizzaIngredientsShorter
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var ingredients = Console.ReadLine().Split().ToArray();
            var maxLenth = int.Parse(Console.ReadLine());
            var count = 0;
            var addedIngredients = new List<string>();
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Length==maxLenth)
                {
                    count++;
                    addedIngredients.Add(ingredients[i]);
                    Console.WriteLine($"Adding {ingredients[i]}.");
                }
                if (count==10)
                {
                    break;
                }
            }
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", addedIngredients)}.");
        }
    }
}
