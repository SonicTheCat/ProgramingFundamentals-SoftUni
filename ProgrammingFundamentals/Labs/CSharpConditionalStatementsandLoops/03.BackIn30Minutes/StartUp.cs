namespace _03.BackIn30Minutes
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 30;
            if (minutes>=60)
            {
                hours++;
                if (hours > 23) hours = 0;
                minutes = minutes - 60;               
            }
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
