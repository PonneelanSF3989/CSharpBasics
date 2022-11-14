using System;
namespace ForLoopAssignment;

class Program
{
    public static void Main(string[] args)
    {
        for (int initial1 = 0 ; initial1 <= 25 ; initial1++ )
        {
            if (initial1 % 2 == 0)
            {
                Console.WriteLine($"Number : {initial1}");

            }
        }

        //user input for start and end of the loop
        Console.WriteLine("Enter the Starting Point of the Loop :");
        int startingPoint = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Ending Point of the Loop :");
        int endingPoint = int.Parse(Console.ReadLine());
        int sum = 0;
        //Looping
        for (int i = startingPoint ; i <= endingPoint ; i++)
        {
            sum = sum + (i * i);
        }
        Console.WriteLine($"Sum of the Square is {sum}");
    }
}