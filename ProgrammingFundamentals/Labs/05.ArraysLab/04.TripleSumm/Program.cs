using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TripleSumm
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            var array = numbers.Split(' ').Select(long.Parse).ToArray();
            var count = true;
            for (long i = 0; i < array.Length; i++)
            {
                for (long j = i; j < array.Length; j++)
                {
                    for (long c = 0; c < array.Length; c++)
                    {
                        if (array[i] + array[j] == array[c] && array[i] > array[j})
                        {
                Console.WriteLine($"{array[i]} + {array[j]} == {array[c]}");
                count = false;
            }
        }
    }
}
        }
    }
}
