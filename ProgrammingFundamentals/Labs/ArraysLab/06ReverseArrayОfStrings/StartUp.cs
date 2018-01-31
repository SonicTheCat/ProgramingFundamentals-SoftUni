namespace _06ReverseArrayОfStrings
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Solution 1:
            //Console.WriteLine(string.Join(" ", Console.ReadLine().Split(' ').Reverse()));

            //Solution 2:
            string input = Console.ReadLine();

            string[] inputSplit = input.Split();

            string output = "";
            for (int i = inputSplit.Length - 1; i >= 0; i--)
            {
                output += inputSplit[i] + " ";
            }
            Console.WriteLine(output.Trim());


            //Solution 3:

            // string letters = Console.ReadLine();
            // string[] sepLetters = letters.Split(' ');
            //
            // for (int i = 0; i < sepLetters.Length/2; i++)
            // {
            //     var temp = sepLetters[i];
            //     sepLetters[i] = sepLetters[sepLetters.Length - 1 - i];
            //     sepLetters[sepLetters.Length - 1 - i] = temp;
            //     //Console.Write($"{sepLetters[i]} ");
            //}
            //
            // for (int i = 0; i < sepLetters.Length; i++)
            // {
            //     Console.Write($"{sepLetters[i]} ");
            // }
            // Console.WriteLine();       
        }
    }
}
