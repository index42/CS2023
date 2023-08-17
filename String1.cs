using System.Data;
using System;
namespace CS2023
{
    static class String1Test
    {
        public static void Test()
        {
            var apple = new { Item = "apples", Price = 1.35 };
            var onSale = apple with { Price = 0.79 };
            Console.WriteLine(apple);
            Console.WriteLine(onSale);
        }
        public static void TestNum()
        {
            double third = 1.0 / 3.0;
            Console.WriteLine(third);
            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            decimal min1 = decimal.MinValue;
            decimal max1 = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min1} to {max1}");

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