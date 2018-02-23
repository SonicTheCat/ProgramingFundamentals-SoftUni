namespace _01.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] contacts = Console.ReadLine()
                .Split()
                .ToArray();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (contacts[0] != "END")
            {
                if (contacts[0] == "A")
                {
                    var numbers = contacts[2];
                    phonebook[contacts[1]] = numbers;
                }
                if (contacts[0] == "S")
                {
                    if (phonebook.ContainsKey(contacts[1]))
                    {
                        Console.WriteLine($"{contacts[1]} -> {phonebook[contacts[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {contacts[1]} does not exist.");
                    }
                }
                contacts = Console.ReadLine()
               .Split()
               .ToArray();
            }
        }
    }
}
