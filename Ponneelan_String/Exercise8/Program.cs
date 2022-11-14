using System;
namespace Exercise8;

class Program{
    public static void Main(string[] args)
    {
        
        System.Console.Write("Enter the String: ");
        string str = Console.ReadLine().ToLower();

        System.Console.Write("Input the position to start ");
        int position = int.Parse(Console.ReadLine());

        System.Console.Write("Input the length of substring : ");
        int length = int.Parse(Console.ReadLine());

        int count;
        string newString="";

        for(count=position;count<length+position;count++){
            newString+=str[count];
        }
        System.Console.WriteLine("The substring retrieve from the string is : "+newString);
    }
}