using System;
namespace Exercise3;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number 1");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number 2");
        int num2 = int.Parse(Console.ReadLine());
        void SwapNumber(int a , int b)
        {
            num1 = b;
            num2 = a;
        }

        SwapNumber(num1,num2);
        Console.WriteLine("After Swapping");
        Console.WriteLine($"Number 1 {num1}");
        Console.WriteLine($"Number2 {num2}");

    }
}