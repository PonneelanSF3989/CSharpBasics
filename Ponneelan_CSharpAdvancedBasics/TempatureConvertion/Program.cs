using System;
namespace TempratureConcertion;

class Program 
{
    public static void Main(string[] args)
    {
        // get the input from the user
        Console.WriteLine("Enter the Celsius :");
        int celsius1 = int.Parse(Console.ReadLine());

        //display the celsius to fahrenheit and kelvin

        Console.WriteLine($"Kelvi : {(float)(celsius1+273.15)}");
        Console.WriteLine($"Fahrenheit : {(float)((celsius1 * 9/5) + 32)}");


    }
}