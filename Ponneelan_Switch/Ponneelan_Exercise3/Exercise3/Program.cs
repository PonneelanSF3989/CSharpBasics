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
                Console.WriteLine("31 days");
                break;
            }
             case 2 :
            {
                Console.WriteLine(" 28days");
                break;
            } case 3 :
            {
                Console.WriteLine("31days");
                break;
            }
             case 4:
            {
                Console.WriteLine("30 days");
                break;
            }
             case 5 :
            {
                Console.WriteLine("31 days");
                break;
            }
             case 6 :
            {
                Console.WriteLine("30 days");
                break;
            }
             case 7 :
            {
                Console.WriteLine("31 days");
                break;
            }
             case 8 :
            {
                Console.WriteLine("31 days");
                break;
            }
             case 9 :
            {
                Console.WriteLine("30 days");
                break;
            }
             case 10:
            {
                Console.WriteLine("31 days");
                break;
            }
             case 11 :
            {
                Console.WriteLine("30 days");
                break;
            }
             case 12 :
            {
                Console.WriteLine("31 days");
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