using System;
namespace Exercise4;

class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of Items :");
        int items = int.Parse(Console.ReadLine());
        for (int i = 1 ; i<=items;i++)
        {
            Console.WriteLine($"Cupe of the number * {i} = {i*i*i}");
        }
    }
}