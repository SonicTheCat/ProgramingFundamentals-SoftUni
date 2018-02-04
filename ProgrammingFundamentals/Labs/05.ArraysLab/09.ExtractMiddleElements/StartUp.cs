namespace _09.ExtractMiddleElements
{
    using System.Linq;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var size = input.Length;
            
            if (size==1)
            {
                Console.WriteLine($"{{ {input[0]} }}");
            }
            else if(size % 2 == 0)
            {
                var middleNums = EvenExtract(input, size);
                Console.Write($"{{ {EvenExtract(input,size)[0]}, {EvenExtract(input,size)[1]} }}");
            }
            else
            {
                Console.Write($"{{ {OddExtract(input,size)[0]}, {OddExtract(input,size)[1]}, {OddExtract(input,size)[2]} }}");
            }
            Console.WriteLine(); 
        }

        static int[] OddExtract(int[] input, int size)
        {
            int[] middleNums = { input[size / 2-1], input[size/2], input[size / 2 + 1] };
            return middleNums;   
        }

        static int[] EvenExtract(int[] input, int size)
        {
            int[] middleNums = { input[size / 2-1], input[size / 2 ] };
            return middleNums;
        }
    }
}
