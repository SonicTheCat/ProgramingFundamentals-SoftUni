namespace _08.CaloriesCounter
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int calories = 0;
            for (int i = 1; i <= n; i++)
            {
                string ingredients = Console.ReadLine().ToLower();
                if (ingredients == "cheese") calories += 500;
                if (ingredients == "tomato sauce") calories += 150;
                if (ingredients == "salami") calories += 600;
                if (ingredients == "pepper") calories += 50;
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
