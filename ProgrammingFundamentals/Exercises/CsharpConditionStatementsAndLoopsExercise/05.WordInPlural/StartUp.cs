namespace _05.WordInPlural
{
    using System;

   public class StartUp
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            bool endsES = word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z");

            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length - 1);
                word += "ies";
            }
             
            else if (endsES)
                word += "es";
            else
                word += "s";

            Console.WriteLine(word);

        }
    }
}
