namespace _03.SearchForNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int takeElements = elements[0];
            int deleteElements = elements[1];
            int findNumber = elements[2];

            for (int i = 0, count=0;  i < deleteElements; i++)
            {
                numbers.RemoveAt(count);
            }
            var leftElements = takeElements - deleteElements;
            for (int i = 0; i < leftElements; i++)
            {
                if (numbers[i] == findNumber)
                {
                    Console.WriteLine("YES!");
                    return;
                }
            }
            Console.WriteLine("NO!");
        }
    }
}
