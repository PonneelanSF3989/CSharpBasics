using System;
namespace Exercise4;

class Program 
{
    public static void Main(string[] args)
    {
        int num;

        do 
        {
            Console.WriteLine("Enter the number");
            num =  int.Parse(Console.ReadLine());
            if (num > 0 && num <=10)
            {
                Console.WriteLine("is Valid number");
            }
            else
            {
                Console.WriteLine("Is Invalid number please enter again");
            }
        }while(!(num>0));
       
    }
}