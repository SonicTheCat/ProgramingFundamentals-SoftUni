namespace _01.CenturiesToMinutes
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years * 365.2422);
            uint hours = 24 * days;
            long minuytes = 60 * hours;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} = {minuytes} minutes");
        }
    }
}
