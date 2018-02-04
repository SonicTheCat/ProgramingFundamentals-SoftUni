namespace _04.TripleSum
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            var array = numbers.Split(' ').Select(long.Parse).ToArray();
            var count = true;
            for (long i = 0; i < array.Length; i++)
            {
                for (long j = i+1; j < array.Length; j++)
                {
                    for (long c = 0; c < array.Length; c++)
                    {
                        if (array[i] + array[j] == array[c])
                        { 
                                Console.WriteLine($"{array[i]} + {array[j]} == {array[c]}");
                                count = false;
                                break;                             
                        }
                    }
                }
            }

            if (count)
            {
                Console.WriteLine("No");
            }
        }
    }
}
