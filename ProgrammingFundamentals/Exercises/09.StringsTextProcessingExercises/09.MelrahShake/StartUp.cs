namespace _09.MelrahShake
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (true)
            {
                int firstIndex = text.IndexOf(pattern);
                int lastIndex = text.LastIndexOf(pattern);

                if ((firstIndex != -1) && (lastIndex != -1) &&
                    (firstIndex != lastIndex) && (pattern.Length > 0))
                {
                    text = text.Remove(firstIndex, pattern.Length);
                    lastIndex = text.LastIndexOf(pattern);
                    text = text.Remove(lastIndex, pattern.Length);

                    int patternMiddle = pattern.Length / 2;
                    pattern = pattern.Remove(patternMiddle, 1);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(text);
                    break;
                }
            }
        }
    }
}
