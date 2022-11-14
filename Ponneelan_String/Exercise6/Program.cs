using System;
namespace Question13;

class Program{
    public static void Main(string[] args)
    {
        int total=0;
        System.Console.Write("Enter the string which has numbers: ");
        string str = Console.ReadLine();

        for(int i=0;i<str.Length;i++){
            string newS = ""+str[i];
            if(str[i]>='0' && str[i]<='9'){
                total += int.Parse(newS);
            }
        }
        System.Console.WriteLine("Total: "+total);
    }
}