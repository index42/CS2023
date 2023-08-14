using System.Data;
using System;
namespace CS2023
{
    static class String1Test
    {
        public static void Test()
        {
            WeatherData weatherData = new();
            Console.WriteLine($"The low and high temperature on {weatherData.Date:MM-dd-yyyy}");
            Console.WriteLine($"    was {weatherData.LowTemp} and {weatherData.HighTemp}.");
        }
    }
    class WeatherData
    {
        public DateTime Date { get; set; }
        public string? LowTemp { get; set; }
        public string? HighTemp { get; set; }
    }
    class String1
    {
    }
}