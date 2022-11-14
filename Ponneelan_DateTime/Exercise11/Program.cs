using System;
namespace Exercise11;

class Program
{
    public static void Main(string[] args)
    {
        DateTime toDay = DateTime.Today;
        DateTime add = toDay;

        for (int i=0;i<12;i++)
        {
            Console.WriteLine(add.ToString("MMMM"));
            add = toDay.AddMonths(i);
        }
    }
}