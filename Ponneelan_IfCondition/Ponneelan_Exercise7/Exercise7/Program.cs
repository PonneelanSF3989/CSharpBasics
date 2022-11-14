using System;
namespace Exercise7;

class Program
{
    public static void Main(string[] args)
    {
        int unit,cusId;
        float subCharge=0,bill;
        Console.WriteLine("Enter customer ID");
        cusId = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Customer name");
        String cusName =  Console.ReadLine();
        Console.WriteLine("Unit Consumed ");
        unit = int.Parse(Console.ReadLine());


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine($"Customer name : {cusName}");
        Console.WriteLine($"Cutomer ID : {cusId}");

        if (unit <=200)
        {
            bill = unit * (float)1.2;
            if (unit<50)
            {
                bill =100;
              
            }
        }
        else if (unit>200 && unit <400)
        {
            bill = unit * (float)1.5;
            
            if (bill > 400)
            {
                subCharge =  bill * (float)0.15;
            }
            else
            {
                subCharge = 0;
            }
                Console.WriteLine($"units {unit}");
                Console.WriteLine($"charge per unit {1.5}");
                Console.WriteLine($"subcharge {subCharge}");
                Console.WriteLine($"Charge for units : {bill}");
                Console.WriteLine($"Amount {bill+subCharge}");
        }
         else if (unit>400 && unit <600)
        {
            bill = unit * (float)1.8;
            
            if (bill > 400)
            {
                subCharge =  bill * (float)0.15;
            }
            else
            {
                subCharge = 0;
            }
                Console.WriteLine($"units {unit}");
                Console.WriteLine($"charge per unit {1.8}");
                Console.WriteLine($"subcharge {subCharge}");
                Console.WriteLine($"Charge for units : {bill}");
                Console.WriteLine($"Amount {bill+subCharge}");
        } else if (unit>600)
        {
            bill = unit * (float)2.0;
            
            if (bill > 400)
            {
                subCharge =  bill * (float)0.15;
            }
            else
            {
                subCharge = 0;
            }
                Console.WriteLine($"units {unit}");
                Console.WriteLine($"charge per unit {2.0}");
                Console.WriteLine($"subcharge {subCharge}");
                Console.WriteLine($"Charge for units : {bill}");
                Console.WriteLine($"Amount {bill+subCharge}");
        }
        else 
        {
            Console.WriteLine("Invalid");
        }


    }
}