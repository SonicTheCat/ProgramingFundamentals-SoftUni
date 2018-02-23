namespace _01.DayofWeek
{
    using System;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            DateTime myDate = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(myDate.DayOfWeek);
            
        }
    }
}
