using System;
namespace Exercise5;

class Program
{
    public static void Main(string[] args)
    {


        Console.WriteLine("Enter the Your option :  ");
        string option = Console.ReadLine().ToLower();
        switch (option)
        {
           
             case "india" :
            {
                Console.WriteLine("Dhoni");
                Console.WriteLine("Kohli");
                Console.WriteLine("Rohit");
                break;
            }
             case "Pakistan" :
            {
                Console.WriteLine("azam");
                Console.WriteLine("shereef");
                Console.WriteLine("rizwan");
                break;
            } case "australia" :
            {
                Console.WriteLine("Smith");
                Console.WriteLine("Starc");
                Console.WriteLine("Warner");
                break;
            }
          

             
            default :
            {
                Console.WriteLine("Invalid");
                break;
            }

        }
    }
}