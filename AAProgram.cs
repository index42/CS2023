﻿using System.Data;
using System;

namespace CS2023;

class Hello
{
    static void Main(string[] args)
    {
        Deconstruct1Test.Test();
    }
    // static async Task Main()
    // {
    //     await Pattern1Test.Test();
    // }
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
