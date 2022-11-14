using System;
namespace Excercise6;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Radius  :  ");
        int radisuOfCirlce = int.Parse(Console.ReadLine());
        Console.WriteLine("1.Area :");
        Console.WriteLine("2.Perimeter :");
        Console.WriteLine("3.Diameter :");
        Console.WriteLine("4.Exit :");
        int optionToPerform = int.Parse(Console.ReadLine());

        
        switch (optionToPerform)
        {
           
             case 1 :
            {
                float areaOfCircle =  (float)(3.14) * (radisuOfCirlce * radisuOfCirlce);
                Console.WriteLine($"Area of Circle id {areaOfCircle}");
                break;
            }
             case 2 :
            {
                float periMeter = 2 * (float)(3.14) * radisuOfCirlce;
                Console.WriteLine($"Perimeter of circle is {periMeter}");
                break;
            } case 3 :
            {
                int diaMeter =  2 * radisuOfCirlce;
                Console.WriteLine($"DiaMeter of circle id {diaMeter}");
                break;
            }
            case 4:
            {
                break;
            }
          

             
            default :
            {
                Console.WriteLine("Invalid");
                break;
            }

        }
    }
}