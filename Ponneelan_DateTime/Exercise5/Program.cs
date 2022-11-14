using System;

namespace Exercise5;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the start year");
        DateTime start = DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        Console.WriteLine("Enter the end year");
        DateTime end = DateTime.ParseExact(Console.ReadLine(),"yyyy",null);

        TimeSpan span = end - start;
        int totalYear = span.Days/365;

        for (int i = 0; i<=totalYear ;i++)
        {

            
            end =start;
            start = start.AddYears(1);
            span = start - end;
            Console.WriteLine($"{start.Year-1} days of {span.Days}");   
        }
    }
}