using System;
namespace Exercise9;

class Program 
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Enter the number :");
        int num1 = int.Parse(Console.ReadLine());
        //Console.WriteLine();
        int temp1 = num1, reminder,result=0;
        while(temp1 != 0)
        {
            reminder = temp1 % 10;
            result += (reminder*reminder*reminder);
            temp1 /=10;
        }

        if (result == num1)
        {
            Console.WriteLine($"{num1} is Armstrong");
        }
        else 
        {
            Console.WriteLine($"{num1} is Not a Armnstrong");
        }
    }
}