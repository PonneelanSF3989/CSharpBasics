using System;
namespace MethodAssignments;

class Program 
{
    public static void Main(string[] args)
    {
        string repeat;

        //Addition
        int Addition(int a ,int b)
        {
            return a+b;
        }

        //Subraction
        int Subraction(int a , int b)
        {
            return a-b;
        }

        //Multiplication
        int Multiplication(int a, int b)
        {
            return a*b;
        }

        //Division
        float Division(int a, int b)
        {
            return (float)a/b;
        }

        do
        {
            Console.WriteLine("Enter the Option :");
            Console.WriteLine("1.Addition :");
            Console.WriteLine("2.Subraction :");
            Console.WriteLine("3.Multiplication :");
            Console.WriteLine("4.Division :");

            int option = int.Parse(Console.ReadLine());

            //Input to perform operation
            Console.WriteLine("Enter the number One");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the nuumber Two");
            int num2 = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1 :
                {
                    Console.WriteLine($"Addition of Two value is {Addition(num1,num2)}");
                    break;
                }
                case 2 :
                {
                    Console.WriteLine($"Subraction of Two value is {Subraction(num1,num2)}");
                    break;
                }
                case 3 :
                {
                    Console.WriteLine($"Multplication of Two value is {Multiplication(num1,num2)}");
                    break;
                }
                case 4 :
                {
                    Console.WriteLine($"Division of Two value is {Division(num1,num2)}");
                    break;
                }
                default :
                {
                    Console.WriteLine("Invalid input");
                    break;
                }
            }
            
            Console.WriteLine("if you want to Continue Press 'yes' othewise press 'no' :");
            repeat =  Console.ReadLine();
        }while(repeat!="no");

    }
}