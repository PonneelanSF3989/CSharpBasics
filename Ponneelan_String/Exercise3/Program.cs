using System;
namespace Exercise3;

class Program 
{
    public static void Main(string[] args)
    {
        string str = "Sysncfusion";
        int lenght = str.Length;
       // Console.Write(lenght);
        for (int i = lenght-1; i>0 ;i--)
        {
           Console.Write(str[i]+" ");

        }
    }
}