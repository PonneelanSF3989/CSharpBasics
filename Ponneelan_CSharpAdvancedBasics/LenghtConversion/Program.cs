using System;
namespace LenghtConversion;

class  Program
{
    public static void Main(string[] args)
    {
        int meter = 10;
        int centiMeter = meter * 100;
        int milliMeter = centiMeter * 10;
        float inch = meter * 39.3f;
        int foot = meter * 12;
        double mile = 0.0006213715277778 * meter;

        Console.WriteLine($"{meter}");
        Console.WriteLine($"{centiMeter}");
        Console.WriteLine($"{milliMeter}");
        Console.WriteLine($"{inch}");
        Console.WriteLine($"{foot}");
        Console.WriteLine($"{mile}");

    }
}