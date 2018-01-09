using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            var count = true;
            for (int one = a; one < b; one++)
            {
                for (int two = a; two < b; two++)
                {
                    for (int thre = a; thre < b; thre++)
                    {
                        for (int four = a; four < b; four++)
                        {
                            for (int five = a; five <=b; five++)
                            {
                                if (a<=one&&one<two&&two<thre&&thre<four&&four<five&&five<=b)
                                {
                                    Console.WriteLine($"{one} {two} {thre} {four} {five}");
                                    count = false;
                                }                              
                            }
                        }
                    }
                }
            }
            if (count==true) Console.WriteLine("No");
        }
    }
}
