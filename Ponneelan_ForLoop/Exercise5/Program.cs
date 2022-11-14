using System;
namespace Exercise4;

class Program 
{
    public static void Main(string[] args)
    {
        int sum = 0;
        Console.WriteLine("Enter the number of Items :");
        int items = int.Parse(Console.ReadLine());
        for (int i = 1 ; i<=items;i++)
        {
            if(i % 2 != 0)
            {
                Console.Write(i + " ");
                sum += i;
            }
        }
        Console.WriteLine($"Sum of th odd Number is : {sum}");
    }
}