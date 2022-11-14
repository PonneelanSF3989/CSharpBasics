using System;
namespace Exercise1;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Your option :  ");
        char option = char.Parse(Console.ReadLine());
        switch (option)
        {
            case 'E' :
            {
                Console.WriteLine("Exellent");
                break;
            }
             case 'G' :
            {
                Console.WriteLine("Good");
                break;
            }
             case 'V' :
            {
                Console.WriteLine("Very good");
                break;
            } case 'A' :
            {
                Console.WriteLine("Avarage");
                break;
            }
             case 'F' :
            {
                Console.WriteLine("Fail");
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