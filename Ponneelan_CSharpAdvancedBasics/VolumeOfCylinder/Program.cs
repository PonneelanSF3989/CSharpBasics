using System;
namespace VolumeOfCylinder;

class Program 
{
    public static void Main(string[] args)
    {

        //get the height and radius of the cylinder from the user
        Console.WriteLine("Enter the Radius :");
        int radius1 =  int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Height :");
        int height1 =  int.Parse(Console.ReadLine());

        // calculate the volume of the cylinder
        float volumeOfCylinder = (float) (3.14 * (Math.Pow(radius1,2)) * (height1));

        //display the volume of the cylinder

        Console.WriteLine($"Volume : {volumeOfCylinder}");
        
    }
}