using System;
namespace Exercise1;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Your option :  ");
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
           
             case 1 :
            {
                Console.WriteLine("Monday");
                break;
            }
             case 2 :
            {
                Console.WriteLine(" Tuesday");
                break;
            } case 3 :
            {
                Console.WriteLine("Wednessday");
                break;
            }
             case 4:
            {
                Console.WriteLine("Thursday");
                break;
            }
             case 5 :
            {
                Console.WriteLine("Friday");
                break;
            }
             case 6 :
            {
                Console.WriteLine("Satusday");
                break;
            }
             case 7 :
            {
                Console.WriteLine("Sunday");
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