using System;
namespace IfStatementAssignment;

class Program
{
    public static void Main(string[] args)
    {
        //Read the Input from the user
        Console.WriteLine("Enter Your Mark");
        int yourMark  = int.Parse(Console.ReadLine());
        
        
        //check the condition and display the grade
        if (yourMark > 80 && yourMark <=100)
        {
            Console.WriteLine("Grade A :");
        }
        else if (yourMark > 60 && yourMark <= 80)
        {
            Console.WriteLine("Grade B");
        }
        else if (yourMark > 35 && yourMark <= 60)
        {
            Console.WriteLine("Grade C");
        }
        else if (yourMark >= 0 && yourMark <=35)
        {
            Console.WriteLine("Grade D");
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}