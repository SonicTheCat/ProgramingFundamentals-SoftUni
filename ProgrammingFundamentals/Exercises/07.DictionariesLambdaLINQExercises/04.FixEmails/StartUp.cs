namespace _04.FixEmails
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var dictEmails = new Dictionary<string, string>();
            while (true)
            {
                var name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                var email = Console.ReadLine().Split('.');
                if (email[1] == "us" || email[1] == "uk")
                {

                    continue;
                }
                else
                {
                    dictEmails[name] = $"{email[0]}.{email[1]}";
                }
            }

            foreach (var pair in dictEmails)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
