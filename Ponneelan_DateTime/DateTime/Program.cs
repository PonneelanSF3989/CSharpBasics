using System;
namespace DateTime1;

class Program
{
    public static void Main(string[] args)
    {
        DateTime date = new DateTime(2021,8,10,10,40,32);
        Console.WriteLine($"{date}");
        Console.WriteLine($"Year :{date.Year}");
        Console.WriteLine($"Month : {date.Month}");
        Console.WriteLine($"Date : {date.Day}");
        Console.WriteLine($"Hours :{date.Hour}");
        Console.WriteLine($"Minutes :{date.Minute}");
        Console.WriteLine($"seconds : {date.Second}");

        string dateString = date.ToString();

        string[] dateArray =  new string[50];

        dateArray = dateString.Split(new string[] {" ","/",":"},StringSplitOptions.None);
        // foreach(string x in dateArray)
        // {
        //     Console.Write(x+ " ");
        // }
        for (int i = dateArray.Length-1;i>=0;i--)
        {
            Console.Write($"{dateArray[i]} ");
        }


        //get the date time fromthe user


        DateTime getDate = new DateTime();
    Console.WriteLine();
        Console.WriteLine("Enter the Date these format (yyyy/MM/dd hh:mm:ss tt)");
        getDate = DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null);
        Console.WriteLine($"Year : {getDate.Year} Month : {getDate.Month} Day : {getDate.Day}",null);

    }
}