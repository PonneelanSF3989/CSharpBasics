using System;
namespace Exercise4;

class Program 
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Enter the number of Items :");
        int items = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for (int i = 1 ; i<=items;i++)
        {
            for (int j = 0 ; j<i ; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}