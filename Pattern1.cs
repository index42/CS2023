using System.Data;
using System;
using System.Runtime.CompilerServices;

namespace CS2023;
static class Pattern1Test
{
    public static async Task Test()
    {
        string arg = "aa";
        _ = arg ?? throw new ArgumentNullException(paramName: nameof(arg), message: "arg can't be null");
        await ExecuteAsyncMethods();
    }
    private static async Task ExecuteAsyncMethods()
    {
        Console.WriteLine("About to launch a task...");
        _ = Task.Run(() =>
        {
            Console.WriteLine("1 " + DateTime.Now);
            var iterations = 0;
            for (int ctr = 0; ctr < int.MaxValue; ctr++)
                iterations++;
            Console.WriteLine("2 " + DateTime.Now);
            Console.WriteLine("Completed looping operation...");
            throw new InvalidOperationException();
        });
        Console.WriteLine("3 " + DateTime.Now);
        await Task.Delay(1000);
        Console.WriteLine("4 " + DateTime.Now);
        Console.WriteLine("Exiting after 5 second delay");
    }
    public static void Test0816()
    {
        Console.WriteLine(PerformOperation(Operation.Start));
        Console.WriteLine(WaterState(30));
        Order order = new Order(6, 600);
        Console.WriteLine(CalculateDiscount(order));


        //         string text = @"04-01-2020, DEPOSIT,    Initial deposit,            2250.00
        // 04-15-2020, DEPOSIT,    Refund,                      125.65
        // 04-18-2020, DEPOSIT,    Paycheck,                    825.65
        // 04-22-2020, WITHDRAWAL, Debit,           Groceries,  255.73
        // 05-01-2020, WITHDRAWAL, #1102,           Rent, apt, 2100.00
        // 05-02-2020, INTEREST,                                  0.65
        // 05-07-2020, WITHDRAWAL, Debit,           Movies,      12.57
        // 04-15-2020, FEE,                                       5.55";
    }
    // The example displays output like the following:
    //       About to launch a task...
    //       Completed looping operation...
    //       Exiting after 5 second delay
    // public static decimal CatchRecords(string input)
    // {
    //     decimal balance = 0m;
    //     using (StringReader reader = new StringReader(input))
    //     {
    //         string line = string.Empty;
    //         while ((line = reader.ReadLine()) != null)
    //         {
    //             string[] transaction = line.Split(',');
    //             balance += transaction switch
    //             {
    //                 [_, "DEPOSIT", _, var amount] => decimal.Parse(amount),
    //                 [_, "WITHDRAWAL", .., var amount] => -decimal.Parse(amount),
    //                 [_, "INTEREST", var amount] => decimal.Parse(amount),
    //                 [_, "FEE", var fee] => -decimal.Parse(fee),
    //                 _ => throw new InvalidOperationException($"Record {string.Join(", ", transaction)} is not in the expected format!"),
    //             };
    //             Console.WriteLine($"Record: {string.Join(", ", transaction)}, New balance: {balance:C}");
    //         }
    //     }
    // }
    public record Order(int Items, decimal Cost);
    public static decimal CalculateDiscount(Order order) =>
    order switch
    {
        { Items: > 10, Cost: > 1000.00m } => 0.10m,
        { Items: > 5, Cost: > 500.00m } => 0.05m,
        { Cost: > 250.00m } => 0.02m,
        null => throw new ArgumentNullException(nameof(order), "Can't calculate discount on null order"),
        var someObject => 0m,
        //_ => 0m,
    };
    static string WaterState(int tempInFahrenheit) =>
    tempInFahrenheit switch
    {
        (> 32) and (< 212) => "liquid",
        < 32 => "solid",
        > 212 => "gas",
        32 => "solid/liquid transition",
        212 => "liquid / gas transition",
    };
    public static State PerformOperation(Operation command) =>
    command switch
    {
        Operation.SystemTest => RunDiagnostics(),
        Operation.Start => StartSystem(),
        Operation.Stop => StopSystem(),
        Operation.Reset => ResetToReady(),
        _ => throw new ArgumentException("Invalid enum value for command", nameof(command)),
    };
    public static State PerformOperation2(string command)
    {
        return command switch
        {
            "SystemTest" => RunDiagnostics(),
            "Start" => StartSystem(),
            "Stop" => StopSystem(),
            "Reset" => ResetToReady(),
            _ => throw new ArgumentException("Invalid string value for command", nameof(command)),
        };
    }

    public static State RunDiagnostics() => State.Success;
    public static State StartSystem() => State.Success;
    public static State StopSystem() => State.Success;
    public static State ResetToReady() => State.Success;
    public enum Operation
    {
        SystemTest,
        Start,
        Stop,
        Reset,
        Unknown
    }
    public enum State
    {
        Success
    }
    public static T MidPoint<T>(IEnumerable<T> sequence)
    {
        if (sequence is IList<T> list)
        {
            return list[list.Count / 2];
        }
        else if (sequence is null)
        {
            throw new ArgumentNullException(nameof(sequence), "Sequence can't be null.");
        }
        else
        {
            int halfLength = sequence.Count() / 2 - 1;
            if (halfLength < 0) halfLength = 0;
            return sequence.Skip(halfLength).First();
        }
    }
}

class Pattern1
{
}
