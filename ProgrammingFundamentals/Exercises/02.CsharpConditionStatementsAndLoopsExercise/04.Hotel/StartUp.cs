namespace _04.Hotel
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string month = Console.ReadLine();
            int countOfNights = int.Parse(Console.ReadLine());

            double studioPrice = 50;
            double doublePrice = 65;
            double suitePrice = 75;

            if (month == "June" || month == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;
            }
            if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;
            }
                
            if (countOfNights > 14 && (month == "June" || month == "September")) doublePrice *= 0.90;
            else if (countOfNights > 14 && (month == "July" || month == "August" || month == "December")) suitePrice *= 0.85;
            else if ((month == "May" || month == "October")&& countOfNights>7) studioPrice *= 0.95;
          
            double newPriceStudio = studioPrice * countOfNights;
            double newPriceDouble = doublePrice * countOfNights;
            double newPriceSuite = suitePrice * countOfNights;

            if (countOfNights > 7 && (month == "September" || month == "October")) newPriceStudio -= studioPrice;

            Console.WriteLine($"Studio: {newPriceStudio:F2} lv.");
            Console.WriteLine($"Double: {newPriceDouble:F2} lv.");
            Console.WriteLine($"Suite: {newPriceSuite:F2} lv.");
        }
    }
}
