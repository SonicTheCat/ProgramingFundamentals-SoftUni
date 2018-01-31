namespace _07.SumArrays
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            int[] firstToInt = firstInput.Split(' ').Select(int.Parse).ToArray();
            int[] secondToInt = secondInput.Split(' ').Select(int.Parse).ToArray();
            int bigger = Math.Max(firstToInt.Length, secondToInt.Length);
           
            for (int i = 0; i < bigger; i++)
            {
                Console.Write(firstToInt[i % firstToInt.Length]+secondToInt[i%secondToInt.Length]+" ");
            }                
        }
    }
}
