using System;
namespace StringAssignment;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the String :");
        string word = Console.ReadLine();
        Console.WriteLine("Enter the subStiring");
        string subString = Console.ReadLine();
        string[] splitString = word.Split(new string[] { "","la" },StringSplitOptions.None);
        
        Console.WriteLine(splitString.Length-1);
    }
}