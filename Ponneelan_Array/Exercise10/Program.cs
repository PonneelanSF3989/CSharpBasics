using System;
namespace Exercise7;

class Program 
{
    public static void Main(string[] args)
    {
        int i,j;
        int n = 3;
        int [,] arr1 = new int [20,20];

        Console.WriteLine("Entert the first array elements");
        for (i = 0;i<n;i++)
        {
            for (j = 0;j<n;j++)
            {
                arr1[i,j] = int.Parse(Console.ReadLine());
                //Console.Write("1  ");
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

 

        Console.WriteLine("Transformation of the matrix is");
        for (i = 0; i<n ; i++)
        {
            for (j = 0; j<n ; j++)
            {
                Console.WriteLine($"{arr1[j,i]}\t");
            }
        }
        

    }
}