namespace _04.DrawFilledSquare
{
    using System;

    public class StartUp
    {
        static void DrawHeaderAndBottom(int n)
        {
            Console.WriteLine(new string('-',n*2));
        }
        static void PrintFigure(int n)
        {
                Console.Write("-");
                for (int j = 0; j < (2 * n - 2) / 2; j++)
                    Console.Write("\\/");
                Console.WriteLine("-");
        }

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            DrawHeaderAndBottom(n);
            for (int i = 0; i < n-2; i++)
            {
                PrintFigure(n);
            }
            DrawHeaderAndBottom(n);
        }
    }
}
