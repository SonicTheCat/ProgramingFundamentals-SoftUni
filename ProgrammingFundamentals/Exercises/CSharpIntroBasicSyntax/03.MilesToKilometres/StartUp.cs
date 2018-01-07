using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MilesToKilometres
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());

            double kilometres = miles * 1.60934;
            Console.WriteLine($"{kilometres:f2}");
        }
    }
}
