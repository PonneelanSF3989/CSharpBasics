using System;
namespace Exercise10;

class Program
{
    public static void Main(string[] args)
    {
        string defaultUser = "user";
        string defaultPass = "pass";
        string uname,upass;
        Console.WriteLine("Enter the username ");
        uname = Console.ReadLine();
        Console.WriteLine("Enter the password ");
        upass = Console.ReadLine();

        if (uname == defaultUser && upass == defaultPass)
        {
            Console.WriteLine("Login successfull");
        }
        else
        {
            Console.WriteLine("invalid user");
        }


    }
}