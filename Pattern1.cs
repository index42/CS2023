using System.Data;
using System;
using System.Runtime.CompilerServices;

namespace CS2023;
static class Pattern1Test
{
    public static void Test()
    {
        Console.WriteLine(PerformOperation(Operation.Start));
        Console.WriteLine(WaterState(30));
    }
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
