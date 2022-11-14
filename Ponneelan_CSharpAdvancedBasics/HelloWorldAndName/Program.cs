using System;
namespace HelloWorldAndName;

class Program
{
    public static void Main(string[] args)
    {
        string name1 = "Ponneelan";

        //Concadination
        Console.WriteLine("Hello : "+name1);

        //PlaceHolder
        Console.WriteLine("Hello : {0}",name1);

        //Interpolation

        Console.WriteLine($"Hello : {name1}");
    }
}