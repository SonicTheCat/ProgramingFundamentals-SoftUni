using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string keyWord = Console.ReadLine().ToLower();

            var count = 0;
            var index = text.IndexOf(keyWord);
            while (index!=-1)
            {
                count++;
                index = text.IndexOf(keyWord, index+1);  
            }
            Console.WriteLine(count);
        }
    }
}
