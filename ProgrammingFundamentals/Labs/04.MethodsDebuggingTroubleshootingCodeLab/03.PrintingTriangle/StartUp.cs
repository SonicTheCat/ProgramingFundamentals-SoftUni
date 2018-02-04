namespace _03.PrintingTriangle
{
    using System;

    public class StartUp
    {
        static void NewLine(int start, int end)
        {
            for (int i = start; i <=end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();            
        }
        static void PrintTriangle(int n)
        {
            for (int i = 1; i <=n; i++)
            {
                NewLine(1, i);
            }
            for (int i = 1; i <= n; i++)
            {
                NewLine(1, n - i);
            }
        }
        public static void Main()
        {
            int m = int.Parse(Console.ReadLine());
            PrintTriangle(m);
        }
    }
}
