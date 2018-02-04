namespace _11.PriceChangeAlert
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int countOfPrices = int.Parse(Console.ReadLine());
            double sigThreshold = double.Parse(Console.ReadLine());
            double prices = double.Parse(Console.ReadLine());
            for (int i = 1; i <= countOfPrices-1; i++)
            {
                double oldPrice = prices;
                prices = double.Parse(Console.ReadLine());
                double percentageDiff = PercentageDiff(oldPrice, prices);
                bool diffrenceOrNot = DiffrenceOrNot(sigThreshold, percentageDiff);
                string result = PrintTheAnswer(oldPrice, prices, percentageDiff, diffrenceOrNot);
                Console.WriteLine(result);
            }
        }

        static double PercentageDiff(double oldPrice, double newPrice)
        {
            double result = ((newPrice - oldPrice) / oldPrice) * 100;
            return result;
        }

        static bool DiffrenceOrNot(double sigThreshold, double percentageDiff)
        {
            if (Math.Abs(percentageDiff) >= sigThreshold*100)
            {
                return true;
            }
            return false;
        }

        static string PrintTheAnswer (double oldPrice, double newPrice, double diffrence, bool trueOrFalse)
        {
            string result = "";
            if (diffrence == 0)
            {
                result = string.Format("NO CHANGE: {0}", newPrice);
            }
            else if (!trueOrFalse)
            {
                result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", oldPrice, newPrice, diffrence);
            }
            else if (trueOrFalse && (diffrence > 0))
            {
                result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", oldPrice, newPrice, diffrence);
            }
            else if (trueOrFalse && (diffrence < 0))
            {
                result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", oldPrice, newPrice, diffrence);
            }

            return result;
        }
    }
}
