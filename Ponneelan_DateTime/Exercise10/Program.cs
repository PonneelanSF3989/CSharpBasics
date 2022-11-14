using System;
namespace Exercise10;

class Program
{
    public static void Main(string[] args)
    {
        DateTime toDay = DateTime.Today;
        DateTime tommorow = toDay.AddDays(1);
        DateTime yesterDay = toDay.AddDays(-1);
        Console.WriteLine($"Today is {toDay.DayOfWeek}");
        Console.WriteLine($"Tommorow is {tommorow.DayOfWeek}");
        Console.WriteLine($"Yesterday is {yesterDay.DayOfWeek}");
    }
}