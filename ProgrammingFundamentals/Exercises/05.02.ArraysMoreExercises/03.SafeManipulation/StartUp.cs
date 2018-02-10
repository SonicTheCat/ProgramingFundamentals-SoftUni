namespace _03.SafeManipulation
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split();

            while (true)
            {
                try
                {
                    string[] comand = Console.ReadLine().Split();
                    if (comand[0] == "Reverse")
                    {
                        words = ReverseElementsInArray(words);
                    }
                    else if (comand[0] == "Distinct")
                    {
                        words = DistinctElementsInArray(words);
                    }
                    else if (comand[0] == "Replace")
                    {
                        words = ReplaceElementsInArray(words, comand);
                    }
                    else if (comand[0] == "END")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                catch 
                {
                    Console.WriteLine("Invalid input!");
                }
            }

            Console.WriteLine(string.Join(", ", words));
        }

        static string[] ReverseElementsInArray(string[] words)
        {
            Array.Reverse(words);
            return words;
        }

        static string[] DistinctElementsInArray(string[] words)
        {
            words = words.Distinct().ToArray();
            return words;
        }

        static string[] ReplaceElementsInArray(string[] words, string[] comand)
        {
            var index = Convert.ToInt32(comand[1]);
            words[index] = comand[2];
            return words;
        }
    }
}
