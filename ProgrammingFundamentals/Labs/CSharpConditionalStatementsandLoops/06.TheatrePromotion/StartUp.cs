namespace _06.TheatrePromotion
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }
            
            var price = 12;
            if (day == "Weekend") price = 15;
            if (day == "Holiday") price = 5;
            if (age>18&&age<=64)
            {
                price = 18;
                if (day == "Weekend") price = 20;
                if (day == "Holiday") price = 12;
            }
            if (age > 64 && age <= 122)
            {
                price = 12;
                if (day == "Weekend") price = 15;
                if (day == "Holiday") price = 10;
            }
            Console.WriteLine($"{price}$");
        }
    }
}
