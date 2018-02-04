namespace _05.ForeignLanguages
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string language = Console.ReadLine();

            switch (language)
            {
                case "England":
                case "USA": Console.WriteLine("English");break;
                case "Spain": 
                case "Argentina":
                case "Mexico": Console.WriteLine("Spanish");break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
