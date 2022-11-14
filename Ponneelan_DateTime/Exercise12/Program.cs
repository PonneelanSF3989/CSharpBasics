using System;
namespace Exercise12;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the month");
        int month  = int.Parse(Console.ReadLine());

        Console.WriteLine("ENter the year");
        int year  = int.Parse(Console.ReadLine());

        DateTime date =  new DateTime(year,month,20);

        

        Console.WriteLine($"days in {date.ToString("MMMM")} month {DateTime.DaysInMonth(year,month)}");
    }
}