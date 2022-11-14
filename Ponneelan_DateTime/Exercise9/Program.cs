using System;
namespace Exercise9;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the start date");
        DateTime fromDate = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null);
        Console.WriteLine("Enter the end date");
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null);

        for (int i = fromDate.Year ; i<= endDate.Year ; i++)
        {
            
            
            if (i % 4 == 0 && i % 10 != 0 || i%400 == 0)
            {
                Console.WriteLine($"{i} is leep year");
                Console.WriteLine($"one yaer from {i} is {i+1}");
            }
        }
    }
}