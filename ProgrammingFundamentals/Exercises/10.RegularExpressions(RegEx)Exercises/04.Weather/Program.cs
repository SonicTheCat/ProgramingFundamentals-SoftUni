namespace _04.Weather
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            string pattern = @"^[A-Za-z]*([A-Z]{2})([0-9]+\.[0-9]+)([A-Za-z]+)\|";

            Dictionary<string, Forecast> weathers = new Dictionary<string,Forecast>();

            while (input!="end")
            {
                Forecast currentWeather = new Forecast();
                MatchCollection matched = Regex.Matches(input, pattern);
                foreach (Match element in matched)
                {
                    var city = element.Groups[1].ToString();
                    currentWeather.Temperature =
                        Convert.ToDouble(element.Groups[2].ToString());
                    currentWeather.WeatherType = element.Groups[3].ToString();

                    weathers[city] = currentWeather;
                }
                input = Console.ReadLine();
            }

            foreach (var weather in weathers.OrderBy(x=>x.Value.Temperature))
            {
                Console.WriteLine($"{weather.Key} => {weather.Value.Temperature:F2} => {weather.Value.WeatherType}");
            }
        }
    }
    public class Forecast
    {
        public double Temperature { get; set; }
        public string WeatherType { get; set; }
    }
}
