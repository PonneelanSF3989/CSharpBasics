using System;
namespace WhileLoopAssignment;

class Program
{
    public static void Main(string[] args)
    {
        //Exercise 1
        int i = 0;
        while(i <= 25)
        {
           if (i % 2 == 0)
           {
               Console.WriteLine($"Number : {i}");
           }
           i++;
        }


        //Exercise 2

        // function to validaing a number
        bool isNumber(string value)
        {
            int x ;
            float y;
            double z;

            //parsing the input int ,float, double
            bool tempInt = int.TryParse(value, out x);
            bool tempFloat = float.TryParse(value, out y);
            bool tempDouble = double.TryParse(value, out z );

            if (tempInt || tempDouble || tempFloat)
            { 
                return true;
            }
            else{
                return false;
            }
        }

        Console.WriteLine("Enter the Valid Number :");
        string number = Console.ReadLine();
        while(!isNumber(number))
        {
        Console.WriteLine("Invalid input format. Please Enter the Valid Number :");
        //Console.WriteLine("");
        number = Console.ReadLine();
        }
        Console.WriteLine($"{number} is a valid Number");
    }
}