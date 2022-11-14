using System;
namespace Exercise5;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Number ");
        int num1 = int.Parse(Console.ReadLine());

       
        void IsPrime(int n)
        {
            bool flag = true;
            if (n <=2 )
            {
                Console.WriteLine("Is Prime Number");
            }
            else
            {
                int i = 2;
                while(i < n)
                {
                    if (n%i==0)
                    {
                        flag = false ;
                        break;
                    }
                    i++;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Is Prime number");
            }
            else 
            {
                Console.WriteLine("Is not a prime number");
            }
        }
        IsPrime(num1);
    }
}