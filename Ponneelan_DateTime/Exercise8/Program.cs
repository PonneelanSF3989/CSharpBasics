using System;
namespace Exercise8;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the date");
        DateTime date  = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null);

        DateTime behind,future;
        behind = date.AddYears(-1);
        future = date.AddYears(1);
        Console.WriteLine($"current year {date}");
        Console.WriteLine($"after one year {future}");
        Console.WriteLine($"before one year {behind}");
    }
}