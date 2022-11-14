using System;
namespace Exercise4;
class Program
{
 public static void Main(string[] args)
 {
    Console.WriteLine("Enter Number");
    string input = Console.ReadLine();

    int num;
    bool temp = int.TryParse(input,out num);

    while(temp == false)
    {
        Console.WriteLine("Invalid enter again");
        input = Console.ReadLine();
        temp = int.TryParse(input,out num);

    }

   

 }   
}