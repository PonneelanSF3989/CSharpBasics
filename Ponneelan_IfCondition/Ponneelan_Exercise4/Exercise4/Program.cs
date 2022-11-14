using System;
namespace Exercise4;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Number 1");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Number 2");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Number 3");
        int num3 = int.Parse(Console.ReadLine());
        if (num1>num2 && num1>num3)
        {
            Console.WriteLine("Number 1 is Greater");
        }
        else if (num2>num1 && num2>num3)
        {
            Console.WriteLine("Number 2 is Greater");
        }
       
        else 
        {
            Console.WriteLine("Number 3 Greater");
        }
       
    }
}