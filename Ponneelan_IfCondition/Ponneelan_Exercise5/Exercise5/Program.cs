using System;
namespace Exercise5;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Marks in Physics");
        int physicsMarks = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Marks in Maths");
        int mathsMark = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Chemistry");
        int chemistryMarks = int.Parse(Console.ReadLine());
        int sumOfMarks = physicsMarks+mathsMark+chemistryMarks;
        //Console.WriteLine(sumOfMarks);
        float percentageOfMark = ((float)(sumOfMarks)/300) * 100;
        //Console.WriteLine(percentageOfMark);
        if (percentageOfMark > 75)
        {
            Console.WriteLine("The candidate is Eligible for Addmission");
        }
        else 
        {
            Console.WriteLine("The candidate is Not Eligible for Addmission");
        }
       
    }
}