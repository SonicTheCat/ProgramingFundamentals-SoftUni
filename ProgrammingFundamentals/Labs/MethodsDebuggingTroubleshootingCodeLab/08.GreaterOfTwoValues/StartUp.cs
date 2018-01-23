using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.GreaterOfTwoValues
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input=="int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(getMax(first, second));
            }
            else if (input =="char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(getMax(first, second));
            }
            else if (true)
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(getMax(first, second));
            }    
        }
        static int getMax(int first, int second)
        {
          
            if (first >=second)
                return first;
            else
                return second;
        }
        static char getMax(char first, char second)
        {
            if (first>=second)
                return first;
            else
                return second;
        }
        static string getMax(string first, string second)
        {    
            if (first.CompareTo(second)>=0)
                return first;
            else
                return second;
        }
    }
}
