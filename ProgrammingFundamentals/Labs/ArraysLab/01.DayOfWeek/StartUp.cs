namespace _01.DayOfWeek
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string[] daysOfWeek = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday" };

            if (number<=7&&number>=1)
            {
                Console.WriteLine(daysOfWeek[number - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }

           

        }
    }
}
