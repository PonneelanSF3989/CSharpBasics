using System;
namespace Exercise7;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the date one");
        DateTime dateOne = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null);
        Console.WriteLine("Enter the date two");
        DateTime dateTwo = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null);

        int compareDate  = dateOne.CompareTo(dateTwo);

        if (compareDate != 1)
        {
            Console.WriteLine($"{dateOne} is Ealry than {dateTwo}");
        }
        else
        {
            Console.WriteLine($"{dateTwo} is Ealry than {dateOne}");

        }
    }
}