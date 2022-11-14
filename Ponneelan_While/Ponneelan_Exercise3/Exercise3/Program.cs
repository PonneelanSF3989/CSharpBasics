using System;
namespace Exercise3;

class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("");
        int i = 0;
        int num1 = 0 ,num2 = 1,next = 0;

        while(i<10)
        {
            Console.Write($"{next} ");
            next = num1+num2;
            num1 = num2;
            num2 = next;
            i++;
        }
        //Console.WriteLine($"Sum : {sum}");
        
    }
}