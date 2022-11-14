using System;
namespace Exercise5;

class Program
{
    public static void Main(string[] args)
    {
        void Fibonacci(int n)
        {
            int num1 = 0;
            int num2 =  1;
            int next = 0;
            int i = 2;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            while(i < 5)
            {
                next =  num1+num2;
                Console.WriteLine(next);
                num1 = num2;
                num2 = next;
                i++;
            }

        }

        Console.WriteLine("Enter the Number");
        int num1 = int.Parse(Console.ReadLine());
        Fibonacci(5);
    }
}