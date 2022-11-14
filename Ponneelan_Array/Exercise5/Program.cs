using System;
namespace Exercise4;

class Program 
{
    public static void Main(string[] args)
    {
        int min = 0,max = 0;

        Console.WriteLine("Enter the sixe of array");
        int size =  int.Parse(Console.ReadLine());
        int[] array = new int[size];

        for (int i = 0 ; i < size ; i++)
        {
            int element;
            Console.WriteLine($"Element {i} :");
            element = int.Parse(Console.ReadLine());
            array[i] = element;
        }

       foreach(int x in array)
       {
        if(x > max) 
        {
            max = x;
        }
       }
        foreach(int x in array)
       {
        if(x < min) 
        {
            min = x;
        }
       }
       Console.WriteLine($"maximum num is {max}");
       Console.WriteLine($"minimum num is {min}");

    }
}