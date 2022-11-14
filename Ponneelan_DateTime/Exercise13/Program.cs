using System;
namespace Exercise13;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter the date");
        int date = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the month");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the year");
        int year = int.Parse(Console.ReadLine());


        //create the obj to DateTime
        DateTime day = new DateTime(year,month,date);
        Console.WriteLine("formated date is " + day.ToString("dd/MM/yyyy"));
        if (day.ToString("ddddd") == "sunday")
        {
            Console.WriteLine("last day of the week is " + day.AddDays(5).ToString("dd/MM/yyyy"));
        }
        else if (day.ToString("ddddd").ToLower() == "monday")
        {
            Console.WriteLine("last day of the week is " + day.AddDays(4).ToString("dd/MM/yyyy"));
        }
        else if (day.ToString("ddddd").ToLower() == "tuesday")
        {
            Console.WriteLine("last day of the week is " + day.AddDays(3).ToString("dd/MM/yyyy"));
        }
        else if (day.ToString("ddddd").ToLower() == "wednesday")
        {
            Console.WriteLine("last day of the week is " + day.AddDays(2).ToString("dd/MM/yyyy"));
        }
        else if (day.ToString("ddddd").ToLower() == "thursday")
        {
            Console.WriteLine("last day of the week is " + day.AddDays(1).ToString("dd/MM/yyyy"));
        }
        else  if (day.ToString("ddddd").ToLower() == "saturday")
        {
            Console.WriteLine("last day of the week is " + day.AddDays(-1).ToString("dd/MM/yyyy"));
        }
        else 
        {
            Console.WriteLine("This is Week day");
        }
    }
}