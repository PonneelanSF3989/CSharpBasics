using System;
namespace Exercise3;

class Program 
{
    public static void Main(string[] args)
    {
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

        Console.WriteLine($"Even Numbers are ");
        foreach(int x in array)
        {
            if (x %2==0)
            {
                Console.Write(x + " ");
            }
        }
        Console.WriteLine();
        Console.WriteLine($"odd Numbers are ");
        foreach(int x in array)
        {
            if (x %2!=0)
            {
                Console.Write(x + " ");
            }
        }
    }
}