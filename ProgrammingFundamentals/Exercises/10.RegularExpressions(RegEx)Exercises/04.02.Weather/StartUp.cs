namespace _04._02.Weather
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            string pattern = @"^[A-Za-z]*([A-Z]{2})([0-9]+\.[0-9]+)([A-Za-z]+)\|";

            Dictionary<string, Forecast> weathers = new Dictionary<string, Forecast>();

            while (input != "end")
            {
                var match = Regex.Match(input, pattern);

                if (Regex.IsMatch(input,pattern))
                {
                    string city = match.Groups[1].ToString();
                    double temperature = double.Parse(match.Groups[2].ToString());
                    string weatherType = match.Groups[3].ToString();
                    Forecast currForecast = new Forecast(temperature, weatherType);
                    weathers[city] = currForecast;
                }
                input = Console.ReadLine();
            }

            foreach (var weather in weathers.OrderBy(x=>x.Value.Temperature))
            {
                Console.WriteLine($"{weather.Key} => {weather.Value.Temperature:F2} => {weather.Value.WeatherType}");
            }
        }
    }
    class Forecast
    {
        public double Temperature { get; set; }
        public string WeatherType { get; set; }

        public Forecast(double temp, string weather)
        {
            this.Temperature = temp;
            this.WeatherType = weather;
        }
    }
}
