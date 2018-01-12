namespace _10.CenturiesToNanoseconds
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            byte centuries = byte.Parse(Console.ReadLine());
            short years = (short)(centuries * 100);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60;
            decimal seconds = minutes * 60;
            decimal miliseconds = seconds * 1000;
            decimal microsends = miliseconds * 1000;
            decimal nanoseconds = microsends * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microsends} microseconds = {nanoseconds} nanoseconds");

        }
    }
}
