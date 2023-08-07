using System.Data;
using System;

class Hello
{
    static void Main()
    {
        Console.WriteLine("Hello, World1");
        Console.WriteLine("Hello, World2");
        Seasons t = Seasons.All;
        Console.WriteLine(Convert.ToInt32(t));
    }
}

public enum Seasons
{
    None = 0,
    Summer = 1,
    Autumn = 2,
    Winter = 4,
    Spring = 8,
    All = Summer | Autumn | Winter | Spring
}