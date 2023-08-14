using System.Data;
using System;

namespace CS2023
{
    class Hello
    {
        static async Task Main()
        {
            await Async1Test.Test();
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
}