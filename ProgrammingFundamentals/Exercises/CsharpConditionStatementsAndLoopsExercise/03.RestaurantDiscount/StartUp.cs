namespace _03.RestaurantDiscount
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();
            double price = 3000 * 0.95;
            string hall = "Small Hall";
            if (countOfPeople>120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (package == "gold")
                price = 3250 * 0.90;
            else if (package == "platinum")
                price = 3500 * 0.85;
            if (countOfPeople > 50 && countOfPeople <= 100)
            {
                hall = "Terrace";
                if (package == "normal")
                    price = 5500 * 0.95;
                else if (package == "gold")
                    price = 5750 * 0.90;
                else
                    price = 6000 * 0.85;
            }
            else if (countOfPeople > 100 && countOfPeople <= 120)
            {
                hall = "Great Hall";
                if (package == "normal")
                    price = 8000 * 0.95;
                else if (package == "gold")
                    price = 8250 * 0.90;
                else
                    price = 8500 * 0.85;
            }
            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {price/countOfPeople:F2}$");

        }
    }
}
