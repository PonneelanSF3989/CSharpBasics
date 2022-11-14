using System;
namespace Exercise4;
class Program
{
    public static void Main(string[] args)
    {
        string str = "My name is Ponneelan i am for pudukkottai";
        string[] words = str.Split(new string[] {" ",""},StringSplitOptions.None);
        Console.WriteLine($"Words in String : {words.Length}");
    }
}