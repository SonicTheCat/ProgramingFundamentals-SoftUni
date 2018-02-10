namespace _04.SieveOfEratosthenes
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n+1];
            bool[] primes = new bool[numbers.Length];

            FindAllPrimesInRange(numbers, n, primes);
            for (int i = 2; i < numbers.Length; i++)
            {
                if (!primes[i])
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();
        }

        static void FindAllPrimesInRange(int[] numbers, int n, bool[] primes)
        {
            var result = 0L;
            for (int i = 2; i < numbers.Length; i++)
            {
                numbers[i] = i;
                for (int j = 2; j <= Math.Sqrt(n); j++)
                {
                    result = numbers[i] * j;
                    if (result <= n)
                    {
                        primes[result] = true;
                    }
                }
            }        
        }    
    }
}
