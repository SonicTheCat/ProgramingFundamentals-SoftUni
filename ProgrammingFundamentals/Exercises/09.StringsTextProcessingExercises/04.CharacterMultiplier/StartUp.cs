namespace _04.CharacterMultiplier
{
    using System;
    
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            char[] arrOne = input[0].ToCharArray();
            char[] arrTwo = input[1].ToCharArray();

            int shortes = Math.Min(arrOne.Length, arrTwo.Length);
            int sum = 0;
            for (int i = 0; i < shortes; i++)
            {
                sum += arrOne[i] * arrTwo[i];
            }
            int longest = Math.Max(arrOne.Length, arrTwo.Length);
            char[] finaeElements = longest == arrOne.Length ? arrOne : arrTwo;
            for (int i = longest-1; i >= shortes; i--)
            {
                sum += finaeElements[i];
            }
            Console.WriteLine(sum);
        }
    }
}
