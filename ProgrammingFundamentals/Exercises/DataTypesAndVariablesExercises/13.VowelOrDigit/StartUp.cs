namespace _13.VowelOrDigit
{
    using System;

public    class StartUp
    {
      public  static void Main()
        {
            char c = char.Parse(Console.ReadLine());
            bool isDigit = char.IsDigit(c);
            bool vowel = c == 'a' || c == 'o' || c == 'u' || c == 'e' || c == 'i';

            if (isDigit == true)
                Console.WriteLine("digit");
            else if (vowel)
                Console.WriteLine("vowel");
            else
                Console.WriteLine("other");
        }
    }
}
