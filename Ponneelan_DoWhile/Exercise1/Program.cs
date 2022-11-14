using System;
namespace Exercise1;

class Program 
{
    public static void Main(string[] args)
    {
        int num;
        String choice = "";

        do 
        {
            Console.WriteLine("Enter the number");
            num =  int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }

            Console.WriteLine("Do you want condinue");
            choice = Console.ReadLine().ToLower();
        }while(choice == "yes");
    }
}