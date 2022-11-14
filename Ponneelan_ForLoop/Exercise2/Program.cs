using System;
namespace Exercise2;

class Program
{
    public static void Main(string[] args)
    {
        int sum = 0;
        for (int i = 1; i<=10 ; i++)
        {
            int num1 = int.Parse(Console.ReadLine()); 
            sum =sum + num1;
        }
         Console.WriteLine($"Sum of Num : {sum}");
         Console.WriteLine($"Average of sum : {(float)sum/10}");
    }
}