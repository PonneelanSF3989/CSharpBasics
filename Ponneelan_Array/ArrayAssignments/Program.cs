using System;
namespace ArrayAssignment;

class Program
{
    public static void Main(string[] args)
    {
        //declare the arrary
        string[] names = new string[5]; 

        int sizeOfArray = names.Length;

        //get the data for array and print that datas
        for (int i = 0 ; i < sizeOfArray ; i++)
        {
            Console.WriteLine($"total number of Element are {sizeOfArray}");
            Console.WriteLine($"Enter the Element {i+1}");
            string elements = Console.ReadLine();
            names[i] = elements;
        }
        for (int i = 0 ; i<sizeOfArray ; i++)
        {
            Console.WriteLine(names[i]);
        }

        //search the index of the name with for loop
        Console.WriteLine();
        Console.WriteLine("Enter the Search name :");
        string searchName = Console.ReadLine();
        int count = 0 ;
        for (int i = 0 ; i < sizeOfArray ; i++)
        {
            if (names[i] == searchName)
            {
                Console.WriteLine($"The name is present in array at the index of {i}");
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("The name is Not present in array");
        }

      


        // search the name with foreach lop
        int countForEach =0 ;
        foreach (string i in names)
        {
            if (i == searchName)
            {
                countForEach++;
            }

        }
        if (countForEach > 0)
        {
            Console.WriteLine($"The name is present in array at {countForEach} times");
        }
        else
        {
            Console.WriteLine("The name is Not present in array");
        }



    }
}