using System;
namespace Exercise8;
class Program
{
    public static void Main(string[] args)
    {
        int n=5,space,star,num = 1;
        for(int row = 0 ; row < n; row++)
        {
            for (space = n-row;space>0;space--)
            {
                Console.Write(" ");
            }
            for (star = 0; star<row+1;star++)
            {
                Console.Write($"{num} ");
                num++;
            }
            Console.WriteLine();
        }
    }
}