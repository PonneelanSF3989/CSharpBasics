using System;
namespace Exercise6;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Teprature");
        int temp = int.Parse(Console.ReadLine());
        
        if (temp < 0)
        {
            Console.WriteLine("freezing Water");
        }
        else if (temp>0 && temp<=10)
        {
            Console.WriteLine("Very Cold weather");
        }
        else if (temp>10 && temp<=20)
        {
            Console.WriteLine(" Cold weather");
        }
         else if (temp>20 && temp<=30)
        {
            Console.WriteLine("Normal in Temp ");
        } else if (temp>30 && temp<=40)
        {
            Console.WriteLine(" Its Hot ");
        }
        else 
        {
            Console.WriteLine(" Its very Hot ");
        }
       
    }
}