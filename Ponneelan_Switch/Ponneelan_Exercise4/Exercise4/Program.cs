using System;
namespace Exercise4;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first intger :  ");
        int firstInteger = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the secong integer :  ");
        int secondInteger = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Your option :  ");
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
           
             case 1 :
            {
                Console.WriteLine($"{firstInteger + secondInteger}");
                break;
            }
             case 2 :
            {
                Console.WriteLine($"{firstInteger - secondInteger}");
                break;
            } case 3 :
            {
                Console.WriteLine($"{firstInteger * secondInteger}");
                break;
            }
             case 4:
            {
                Console.WriteLine($"{firstInteger / secondInteger}");
                break;
            }
             case 5 :
            {
                
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