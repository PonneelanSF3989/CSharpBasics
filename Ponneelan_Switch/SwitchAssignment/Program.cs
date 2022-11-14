using System;
namespace SwitchAssignment;

class Program
{
    public static void Main(string[] args)
    {
        //get the input from the user to perform operation
        Console.WriteLine("Enter The Number1 :");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter The Number1 :");
        int number2 = int.Parse(Console.ReadLine());

        // get the input from user for choose the operation
        Console.WriteLine("Enter The Oeration '+' '-' '*' '/' '%' :");
        char operation1 = char.Parse(Console.ReadLine());

        switch(operation1)
        {
            case '+' :
            {
                Console.WriteLine($"Addition of Two number : {number1 + number2}");
                break;
            }
            case '-' :
            {
                Console.WriteLine($"Subraction of Two number : {number1 - number2}");
                break;
            }
            case '*' :
            {
                Console.WriteLine($"Multiplication of Two number : {number1 * number2}");
                break;
            }
            case '/' :
            {
                Console.WriteLine($"Division of Two number : {((float)number1 / number2)}");
                break;
            }
             case '%' :
            {
                Console.WriteLine($"Modulo of Two number : {(number1 % number2)}");
                break;
            }
            default :
            {
                Console.WriteLine("Invalid Input");
                break;
            }
            
        }
    }
}