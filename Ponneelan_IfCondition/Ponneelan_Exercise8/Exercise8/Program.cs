using System;
namespace Exercise8;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Teprature");
        int sugerLevel = int.Parse(Console.ReadLine());
        
        if (sugerLevel < 90)
        {
            Console.WriteLine(" Low Suger");
        }
        else if (sugerLevel>=90 && sugerLevel<=130)
        {
            Console.WriteLine("Normal");
        }
        else if (sugerLevel>130 && sugerLevel<=140)
        {
            Console.WriteLine("Medium");
        }
         else if (sugerLevel>140 && sugerLevel<=170)
        {
            Console.WriteLine("highsugar–try to reduce it from now");
        } else if (sugerLevel>170)
        {
            Console.WriteLine("You are a very high Sugar Patient ");
        }
        else 
        {
            Console.WriteLine(" invalid Input ");
        }
       
    }
}