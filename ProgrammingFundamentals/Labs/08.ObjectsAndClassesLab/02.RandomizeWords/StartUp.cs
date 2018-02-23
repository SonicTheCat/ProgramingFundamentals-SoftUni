namespace _02.RandomizeWords
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int index = rnd.Next(0, input.Length);
                string rem = input[index];
                int newIndex = rnd.Next(0, input.Length);
                input[index] = input[newIndex];
                input[newIndex] = rem;
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
