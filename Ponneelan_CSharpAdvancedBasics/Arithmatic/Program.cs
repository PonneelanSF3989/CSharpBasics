using System;
namespace Arithmatic;

class Program
{
    public static void Main(string[] args)
    {

        //Get the input from the user 
        Console.WriteLine("Enter the Number One :");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Number Two :");
        int num2 = int.Parse(Console.ReadLine());

        //Display the Operation
        Console.WriteLine($"Addition : {num1+num2}");
        Console.WriteLine($"Subraction : {num1-num2}");
        Console.WriteLine($"Division: {num1*num2}");
        Console.WriteLine($"Multiplication : {num1/num2}");
        Console.WriteLine($"Modulo : {num1%num2}");
    }
}