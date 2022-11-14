using System;
namespace Operator;

class Prrogram
{
    public static void Main(string[] args)
    {
        int value1 = 15;
        int value2 = 20;

        Console.WriteLine($"value1 > value2 : {value1>value2}");
        Console.WriteLine($"value1 < value2 : {value1<value2}");
        Console.WriteLine($"value1 >= value2 : {value1>=value2}");
        Console.WriteLine($"value1 <= value2 : {value1<=value2}");
        Console.WriteLine($"value1 == value2 : {value1==value2}");
        Console.WriteLine($"value1 != value2 : {value1!=value2}");
        Console.WriteLine($"value1 >10 && value2 > 10 : {value1>10 && value2>10}");
        Console.WriteLine($"value1 >10 || value2 > 30 : {value1>10 || value2>30}");
        Console.WriteLine($"!(value1 > 20): {!(value1>20)}");
        Console.WriteLine($"Value1++ : {value1++}");
        Console.WriteLine($"Value1-- : {value1--}");
        String value = value1==15 ? "true": "false";
        Console.WriteLine($"{value}");

     
    }
}