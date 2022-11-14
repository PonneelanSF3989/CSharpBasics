using System;
namespace Exercise11;

class Program
{
    public static void Main(string[] args)
    {
        int max=0,min=0;
        Console.WriteLine("Enter the string :");
        string nums = Console.ReadLine();

        string[] numArray = nums.Split(new string[] {" ",""},StringSplitOptions.None);

        foreach(string x in numArray)
        {
            if (Convert.ToInt32(x)>max)
            {
                max = Convert.ToInt32(x);
            }
        }
        foreach(string x in numArray)
        {
            if (Convert.ToInt32(x)<min)
            {
                min = Convert.ToInt32(x);
            }
        }

        Console.WriteLine($"Minimum number is {min}");
        Console.WriteLine($"Maximum number is {max}");


    }
}