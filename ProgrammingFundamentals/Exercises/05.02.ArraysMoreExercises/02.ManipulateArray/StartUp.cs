namespace _02.ManipulateArray
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split();
            int countOfComands = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfComands; i++)
            {
                string[] comand = Console.ReadLine().Split();
                if (comand[0]=="Reverse")
                {
                   words= ReverseElementsInArray(words);
                }
                if (comand[0]=="Distinct")
                {
                    words = DistinctElementsInArray(words);
                }
                if (comand[0]=="Replace")
                {
                    words = ReplaceElementsInArray(words, comand);
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
            var index= Convert.ToInt32(comand[1]);
            words[index] = comand[2];
            return words;
        }
    }
}
