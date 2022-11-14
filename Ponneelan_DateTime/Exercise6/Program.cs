using System;
namespace Exercise6;

class Program
{
    public static void Main(string[] args)
    {
        DateTime date = DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy hh:mm:ss tt",null);

        DateTime after40 = date.AddDays(40);
        Console.WriteLine($"days is : {after40.DayOfWeek}");
    }
}