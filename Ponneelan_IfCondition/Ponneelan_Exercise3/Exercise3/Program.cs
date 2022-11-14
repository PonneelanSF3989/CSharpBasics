using System;
namespace Exercise3;

class Program
{
    public static void Main(string[] args)
    {
        int year = 2018;
        if (year % 400 == 0)
        {
            Console.WriteLine("Leep Year");
        }
        else if (year % 100 == 0)
        {
            Console.WriteLine("Leep Year");
        }
        else if (year % 4 == 0)
        {
            Console.WriteLine("Leep Year");
        }
        else 
        {
            Console.WriteLine("Not a Leep Year");
        }
       
    }
}