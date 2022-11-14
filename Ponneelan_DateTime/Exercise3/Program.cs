using System;
namespace Exercise3;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("ENter the date in format (dd/MM/yyyy hh:mm:ss: tt)");
        DateTime getDate = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null);

        Console.WriteLine($"year : {getDate.Year}");
        Console.WriteLine($"month : {getDate.Month}");
        Console.WriteLine($"day : {getDate.Day}");
        Console.WriteLine($"Hours : {getDate.Hour}");
        Console.WriteLine($"Minutes : {getDate.Minute}");
        Console.WriteLine($"Seconds : {getDate.Second}");


    }
}