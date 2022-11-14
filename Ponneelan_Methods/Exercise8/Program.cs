using System;
namespace Exercise8;

class Program
{
    public static void Main(string[] args)
    {
        int mark1,mark2,mark3;
        void GetMarks()
        {
        Console.WriteLine("Enter the mark 1");
        mark1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the mark 2");
        mark2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the mark 3");
        mark3 = int.Parse(Console.ReadLine());
        }
        float PercentageOfMark(int m1,int m2, int m3)
        {
            float persentage ;
            int sum =  m1+m2+m3;
            persentage  = ((float)(sum)/300) * 100;
            return persentage;
        }
        void DisplayMarks(int x, int y, int z,float p)
        {
            Console.WriteLine($"Mark 1 {x}");
            Console.WriteLine($"Mark 1 {y}");
            Console.WriteLine($"Mark 1 {x}");
            Console.WriteLine($"Percentage {p}");
        }

        GetMarks();
        DisplayMarks(mark1,mark2,mark3,PercentageOfMark(mark1,mark2,mark3));
    }
}