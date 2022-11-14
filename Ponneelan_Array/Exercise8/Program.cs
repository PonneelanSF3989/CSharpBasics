using System;
namespace Exercise8;

class Program 
{
    public static void Main(string[] args)
    {
        int i,j;
        int n = 3;
        int [,] arr1 = new int [20,20];
        int [,] arr2 = new int [20,20];
        int [,] sum = new int [20,20];

        Console.WriteLine("Entert the first array elements");
        for (i = 0;i<n;i++)
        {
            for (j = 0;j<n;j++)
            {
                arr1[i,j] = int.Parse(Console.ReadLine());
                //Console.Write("1  ");
            }
        }

        Console.WriteLine("Entert the Second array elements");
        for (i = 0; i<n ; i++)
        {
            for (j = 0; j<n ; j++)
            {
                arr2[i,j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("first array elements are");
        for (i = 0; i<n ; i++)
        {
            for (j = 0; j<n ; j++)
            {
                Console.WriteLine($"{arr1[i,j]}\t");
            }
        }
        Console.WriteLine("Seconf array elements are");
        for (i = 0; i<n ; i++)
        {
            for (j = 0; j<n ; j++)
            {
                Console.WriteLine($"{arr2[i,j]}\t");
            }
        }

        
        for (i = 0; i<n ; i++)
        {
            for (j = 0; j<n ; j++)
            {
                sum[i,j] =  arr1[i,j] - arr2[i,j];
            }
        }

        Console.WriteLine("additio of the two array is");
        for (i = 0; i<n ; i++)
        {
            for (j = 0; j<n ; j++)
            {
                Console.WriteLine($"{sum[i,j]}\t");
            }
        }
        

    }
}