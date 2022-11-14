using System;
namespace Exercise2;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Date format ");
        DateTime getDate = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null);
        Console.WriteLine($"{(getDate.ToString("mm/dd/yyyy"))}");
        Console.WriteLine($"{getDate.ToLongDateString()}");
        Console.WriteLine($"{getDate.ToShortDateString()}");
        Console.WriteLine($"Complete Date  : {getDate.ToString("dd/MM/yyyy hh:mm:ss tt")}");
        Console.WriteLine($"to time only : {getDate.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"to date only : {getDate.ToString("hh:mm:ss tt")}");



    }
}