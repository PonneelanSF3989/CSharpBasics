using System;
namespace Exercise5;
class Program 
{
    public static void Main(string[] args)
    {
        int i = 0, sum = 0;
        while(i<4)
        {
            Console.WriteLine($"Entert the number {i+1}");
            int num = int.Parse(Console.ReadLine());
            sum +=num;
            i++;
        }
        Console.WriteLine($"Sum of Entered Number is {sum}");
    }
}