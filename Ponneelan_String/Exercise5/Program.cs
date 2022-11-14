using System;
namespace Exercise4;

class Program
{
    public static void Main(string[] args)
    {
        string str1 = "Hi Hello";
        string str2 = "hi Hello";
        if (str1 == str2)
        {
            Console.WriteLine("Strings are same");
        }
        else
        {
            Console.WriteLine("Strings are not same");
        }
    }
}