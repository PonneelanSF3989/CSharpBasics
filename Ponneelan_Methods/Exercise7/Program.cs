using System;
namespace Exercise;
class Program
{
    public static void Main(string[] args)
    {
        void IsPalindrome(string x)
        {
            string rev="";
            for(int i = x.Length-1;i>=0;i--)
            {
                rev += x[i].ToString();
            }
            if (x==rev)
            {
                Console.WriteLine("Is palindrome");
            }
            else
            {
                Console.WriteLine("not a palindrome");
            }
            
        }

            Console.WriteLine("Enter the word");
            string word = Console.ReadLine();
            IsPalindrome(word);
    }
}