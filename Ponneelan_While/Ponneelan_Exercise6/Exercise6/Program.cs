using System;
namespace Exercise6;

class program 
{
    public static void Main(string[] args)
    {
        bool isPrime(int num)
        {
            int i, half=0, flag=0;          
            half=num/2;    
            for(i = 2; i <= half; i++)    
            {    
                if(num % i == 0)    
                    {       
                        flag=1;    
                        break;    
                    }    
            }    
            if (flag==0)   
            { 
                return true;
            }
            else
            {
                return false;
            }
        }
        bool isEven(int num)
        {
            if(num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool isOdd(int num)
        {
            if(num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    
        int i = 0;
         Console.WriteLine("Primenumbers :");
        while(i<=100)
        {
            if (isPrime(i))
            {
                Console.Write($"{i} ");
            }
            i++;
        }

        int j = 0;
        Console.WriteLine();
        Console.WriteLine("Odd numbers :");
        while(j<=100)
        {
            if (isOdd(j))
            {
                Console.Write($"{j} ");
            }
            j++;
        }

         int k = 0;
         Console.WriteLine();
        Console.WriteLine("Even numbers :");
        while(k<=100)
        {
            if (isEven(k))
            {
                Console.Write($"{k} ");
            }
            k++;
        }
    
    }
}