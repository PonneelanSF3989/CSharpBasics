using System;
namespace Exercise1;
class Program
{
    public static void Main(string[] args)
    {
        string str = "Syncfusion";
        int count = 0;
        foreach(int i in str)
        {
            count++;
        }
        Console.WriteLine($"LEnght of the string {count}");
    }
}