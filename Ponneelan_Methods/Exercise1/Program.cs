using System;
namespace Exsercise1;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number 1");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number 2");
        int num2 = int.Parse(Console.ReadLine());



        int Addition(int a,int b)
        {
            int sum = a+b;
            return sum;
        }
        int Subraction(int a ,int b)
        {
            int sub = a-b;
            return sub;
        }
        int Multiplication(int a, int b)
        {
            int mul = a*b;
            return mul;
        }
        int Division(int a, int b)
        {
            int div = a/b;
            return div;
        }

        Console.WriteLine($"Addition : {Addition(num1,num2)}");
        Console.WriteLine($"Subraction : {Subraction(num1,num2)}");
        Console.WriteLine($"Multiplication : {Multiplication(num1,num2)}");
        Console.WriteLine($"Division : {Division(num1,num2)}");

    }
}