namespace _03.TextFilter
{
    using System;
   
    public class StartUp
    {
        public static void Main()
        {
            var badWords = Console.ReadLine()
                .Split(new char[] { ',', ' ' },StringSplitOptions
                .RemoveEmptyEntries);

            var text = Console.ReadLine();

            foreach (var word in badWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
          
            Console.WriteLine(text);
        }
    }
}
