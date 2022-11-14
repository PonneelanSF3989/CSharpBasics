using System;
namespace Exercise6;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Number");
        int num1 = int.Parse(Console.ReadLine());
        void IsPrime(int n)
        {
            int sum = 1;
            if (n == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                int i = 1;
                while(i <= n)
                {
                    sum =  sum * i;
                    i++;
                }
            }
            Console.WriteLine($"Factorial of the number {n} is {sum}");
        }
        IsPrime(num1);
    }
}