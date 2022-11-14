using System;
namespace DoWhileAssignment;

class Program
{
    public static void Main(string[] args)
    {
        string isRepeat = "";

        do
        {
            Console.WriteLine("Enter the NUmber :");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"Number {number} is Even");
            }
            else
            {
                Console.WriteLine($"Number {number} is Odd");
            }

            Console.WriteLine("Do you want to Continue Press 'yes' Or 'no'" );
            isRepeat = Console.ReadLine();
            
            while(isRepeat != "yes" && isRepeat != "no")
            {
            Console.WriteLine("Wrong Entry");
            Console.WriteLine("Do you want to Continue Press 'yes' Or 'no'" );
            isRepeat = Console.ReadLine();   
            }
            
        }while(isRepeat == "yes");
    }
}