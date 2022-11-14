using System;
namespace Exercise2;

class Program 
{
    public static void Main(string[] args)
    {
        int num,sum =0 ;

        do 
        {
            Console.WriteLine("Enter the number");
            num =  int.Parse(Console.ReadLine());
            if (num >= 0)
            {
                sum = sum +num;
            }
        }while(num >= 0);
        Console.WriteLine($"sum is :{sum}");
    }
}