using System;
namespace Exercise9;

class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the string: ");
        string str = Console.ReadLine();
        
        System.Console.Write("Enter the Substring: ");
        string subStr = Console.ReadLine();
        
        int check = str.IndexOf(subStr);
        if(check==-1){
            System.Console.WriteLine("The substring does not exist");
        }
        else{
            System.Console.WriteLine("This substring exists");
        }
    }
}