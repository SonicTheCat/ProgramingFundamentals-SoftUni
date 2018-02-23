﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
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
                if (contacts[0] == "ListAll")
                {
                    foreach (var kvp in phonebook.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                }

                contacts = Console.ReadLine()
               .Split()
               .ToArray();
            }
        }
    }
}
