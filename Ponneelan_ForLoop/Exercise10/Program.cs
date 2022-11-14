using System;  
namespace Exercise10;
class Program  
   {  
     public static void Main(string[] args)  
      {  
          int inputNumber, i, half=0, flag=0;    
          Console.Write("Enter the Number to check Prime: ");    
          inputNumber = int.Parse(Console.ReadLine());  
          half=inputNumber/2;    
          for(i = 2; i <= half; i++)    
          {    
           if(inputNumber % i == 0)    
            {    
             Console.Write("Number is not Prime.");    
             flag=1;    
             break;    
            }    
          }    
          if (flag==0)    
           Console.Write("Number is Prime.");       
     }  
   }  