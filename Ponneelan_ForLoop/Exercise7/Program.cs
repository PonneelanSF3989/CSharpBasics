using System;
namespace Exercise7;
class Program
{
    public static void Main(string[] args)
    {
        int n=5;
        for(int row =0 ; row < n; row++)
        {
            for (int space = n-row;space>0;space--)
            {
                Console.Write(" ");
            }
            for (int star = 1; star<row+1;star++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}