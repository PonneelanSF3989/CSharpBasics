using System;
namespace Exercise2;

class Program 
{
    public static void Main(string[] args)
    {
        string str = "Sysncfusion";
        int lenght = str.Length;

        for (int i = 0; i<lenght ;i++)
        {
            Console.Write(str[i]+" ");
        }
    }
}