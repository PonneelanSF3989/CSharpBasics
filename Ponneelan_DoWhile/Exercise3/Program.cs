using System;
namespace Exercise3;

class Program 
{
    public static void Main(string[] args)
    {
        int num;
        void Fibonacci(int n)
        {
            int num1 = 0;
            int num2 =  1;
            int next = 0;
            int i = 2;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            while(i < n)
            {
                next =  num1+num2;
                Console.WriteLine(next);
                num1 = num2;
                num2 = next;
                i++;
            }

        }

        do 
        {
            Console.WriteLine("Enter the number");
            num =  int.Parse(Console.ReadLine());
           if (num >1)
           {
            Fibonacci(num);
           }
           else 
           {
            Console.WriteLine("num is invalid");
           }
        }while(!(num>1));
       
    }
}