using System.Data;
using System;

namespace CS2023;

public record Person(string FirstName, string LastName);

static class Record1Test
{
    public record Person(string FirstName, string LastName, string[] PhoneNumbers);
    public record Person2(string FirstName, string LastName)
    {
        public string[]? PhoneNumbers { get; init; }
    }

    public static void Test()
    {
        Person2 person1 = new("Nancy", "Davolio") { PhoneNumbers = new string[1] };
        Console.WriteLine(person1);
        // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }

        Person2 person2 = person1 with { FirstName = "John" };
        Console.WriteLine(person2);
        // output: Person { FirstName = John, LastName = Davolio, PhoneNumbers = System.String[] }
        Console.WriteLine(person1 == person2); // output: False

        person2 = person1 with { PhoneNumbers = new string[1] };
        Console.WriteLine(person2);
        // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }
        Console.WriteLine(person1 == person2); // output: False

        person2 = person1 with { };
        Console.WriteLine(person1 == person2); // output: True
        // var phoneNumbers = new string[2];
        // string[] phoneNumbers3 = { "t", "t2" };
        // string[] phoneNumbers2 = phoneNumbers3;
        // Person person1 = new("Nancy", "Davolio", phoneNumbers3);
        // Person person2 = new("Nancy", "Davolio", phoneNumbers2);
        // Console.WriteLine(person1 == person2); // output: True

        // person1.PhoneNumbers[0] = "t";
        // person1.PhoneNumbers[1] = "t2";
        // Console.WriteLine(person1 == person2); // output: True

        // Console.WriteLine(ReferenceEquals(person1, person2)); // output: False
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
    }
}
class Record1
{
}