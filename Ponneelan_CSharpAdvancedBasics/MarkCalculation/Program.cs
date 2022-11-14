using System;
namespace MarkCalculation;

class Program
{
    public static void Main(string[] args)
    {
        // get the marks from the user 
        Console.WriteLine("Enter the Marks in Maths");
        int mathsMarks = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Marks in Physics");
        int physicsMarks = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Marks in Chemistry");
        int chemistyMarks = int.Parse(Console.ReadLine());

        int sumOfMarks = mathsMarks + physicsMarks + chemistyMarks;
        float percentageOfMarks = (float) (((float)sumOfMarks/300) * 100 );

        // display the Sum and Percentage of the mark

        Console.WriteLine($"Sum of the Mark is : {sumOfMarks}");
        Console.WriteLine($"Percentage of the Mark is : {percentageOfMarks}");
    }
}