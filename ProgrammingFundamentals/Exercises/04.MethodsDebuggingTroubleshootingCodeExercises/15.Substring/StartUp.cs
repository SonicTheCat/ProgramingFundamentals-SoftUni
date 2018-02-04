using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());
        char search = 'p'; // The letter 'p' was writen in cyrillic and that gives diffrent ascii number! It must be latin letter 'p'.
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == search)
            {
                hasMatch = true;
                int endIndex = count+1; // count+1 see line 25!

                if (endIndex >=text.Length-i)
                // every time we must substract the letters that we have passed already!
                {
                    endIndex = text.Length-i;
                }
                string matchedString = text.Substring(i, endIndex);
                // The substring method expects two parameters:
                //1.The starting index of the substring.Strings are indexed with the first character 0;
                //2.The length of the substring part. For example here we want to print letter 'p' ALONG with count letters to its right.... Thats why it must be count+1;
                Console.WriteLine(matchedString);
                i += count;
            }
        }
        if (!hasMatch)
            Console.WriteLine("no");
    }
}
