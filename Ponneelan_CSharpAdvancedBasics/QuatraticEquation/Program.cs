using System;
namespace QuatraticEquation;

class Program
{
    public static void Main(string[] args)
    {
        // get the input a and b from the user
        Console.WriteLine("Enter the A value :");
        int valueA = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the B value :");
        int valueB = int.Parse(Console.ReadLine());

        int equation1 = (valueA * valueA) + (2 * valueA *valueB) + (valueB * valueB);

        //display the output
        Console.WriteLine($"Output : {equation1}");
    }
}