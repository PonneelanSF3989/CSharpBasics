using System;
namespace Exercise14;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the month");
        int month = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the no leave taken");
        int leave = int.Parse(Console.ReadLine());

        int days = DateTime.DaysInMonth(2022,month);
        Console.WriteLine("Salary of the month "+ (days-leave) * 500);

    }
}