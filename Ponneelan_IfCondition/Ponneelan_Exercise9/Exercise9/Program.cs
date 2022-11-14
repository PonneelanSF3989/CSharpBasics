using System;
namespace Exercise8;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Month");
        string month = Console.ReadLine();
        
        if (month == "December" || month == "January" || month == "February")
        {
            Console.WriteLine("Winter");
        }
        else if (month == "December" || month == "January" || month == "February")
        {
            Console.WriteLine("Winter");
        }
        else if (month == "March" || month == "April" || month == "May")
        {
            Console.WriteLine("spring");
        }
         else if (month == "June" || month == "July" || month == "Augest")
        {
            Console.WriteLine("Summer");
        }
         else if (month == "Septemper" || month == "october" || month == "November")
        {
            Console.WriteLine("monsoon");
        }
        else 
        {
            Console.WriteLine(" invalid Input ");
        }
       
    }
}