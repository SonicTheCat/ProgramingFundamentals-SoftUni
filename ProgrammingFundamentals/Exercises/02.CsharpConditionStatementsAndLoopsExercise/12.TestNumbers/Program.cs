using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;

            for (int i = n; i >=1; i--)
            {
                for (int j = 1; j <=m; j++)
                {
                    sum += 3 * (i * j);
                    count++;
                    if (sum>=stop)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {sum} >= {stop}");
                        return; 
                    }
                }
            }
            Console.WriteLine($"{count} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
