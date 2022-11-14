using System;
namespace Exercise4;
class Program
{
    public static void Main(string[] args)
    {
        DateTime date = new DateTime(7/11/2016);

        Console.WriteLine($"day of the week is : {date.DayOfWeek}");
    }
}