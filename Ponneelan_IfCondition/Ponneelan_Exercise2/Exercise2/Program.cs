using System;
namespace Exercise1;

class Program
{
    public static void Main(string[] args)
    {
        int yourAge = 50;
        if (yourAge >= 18)
        {
            Console.WriteLine("Eligible to vote");
        }
        else
        {
            Console.WriteLine("Not Eligible to vote");
        }
    }
}