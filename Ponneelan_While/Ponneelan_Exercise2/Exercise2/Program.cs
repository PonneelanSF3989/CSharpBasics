using System;
namespace Exercise1;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter No of Items");
        int item = int.Parse(Console.ReadLine());
        int i = 1;
        int sum =0;
        while(i <=item)
        {
            int num1 = int.Parse(Console.ReadLine());
           sum = sum+ (num1*num1);
           i++;
        }
        Console.WriteLine($"Sum : {sum}");
        
    }
}