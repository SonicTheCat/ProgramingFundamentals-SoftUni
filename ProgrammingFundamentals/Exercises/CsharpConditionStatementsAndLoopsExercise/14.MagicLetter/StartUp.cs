namespace _14.MagicLetter
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            string skip = Console.ReadLine();

            for (char i = a; i <= b; i++)
            {
                for (char j = a; j <= b; j++)
                {
                    for (char h = a; h <= b; h++)
                    {
                        string result = $"{i}{j}{h} ";
                        if (!result.Contains(skip))
                        {
                            Console.Write(result);
                        }
                    }
                }
            }
        }
    }
}
