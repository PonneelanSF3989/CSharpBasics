using System;
namespace Exercise11;

class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the String: ");
        string str = Console.ReadLine();
        string newStr="";

        foreach(char chr in str){
            if(!(newStr.Contains(chr))){
                newStr+=chr;
            }
        }
        System.Console.WriteLine(newStr);
    }
}