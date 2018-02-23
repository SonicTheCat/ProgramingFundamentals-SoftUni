namespace _04._02.FixEmails
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var emailbook = new Dictionary<string, string>();
            while (name!="stop")
            { 
                var email = Console.ReadLine();
                if (!email.EndsWith("us")||email.EndsWith("uk"))
                {
                    emailbook[name] = email;
                }
                name = Console.ReadLine();
            }

            foreach (var key in emailbook.Keys)
            {
                Console.WriteLine($"{key} -> {emailbook[key]}");
            }
        }
    }
}
