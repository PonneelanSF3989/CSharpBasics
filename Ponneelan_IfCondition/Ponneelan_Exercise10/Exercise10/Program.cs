using System;
namespace Exercise10;

class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the password :");
        string passWord = Console.ReadLine();

        if (passWord != "HiTeam")
        {
            Console.WriteLine("Wrong Password");
        }
        else
        {
            Console.WriteLine("Right Password");
        }
    }
}