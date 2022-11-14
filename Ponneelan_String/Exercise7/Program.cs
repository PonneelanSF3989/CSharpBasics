using System;
namespace Exercise7;

class Program
{
    public static void Main(string[] args)
    {
        int vowel=0;int consonant=0;
        System.Console.Write("Enter the String: ");
        string str = Console.ReadLine().ToLower();
        

        foreach(char chr in str){
            if(chr=='a'||chr=='e'||chr=='i'||chr=='o'||chr=='u'){
                vowel++;
            }
            else if(chr>='a'&& chr<='z'){
                consonant++;
            }
        }
        
        System.Console.WriteLine(" vowels count : "+vowel);
        System.Console.WriteLine("constant count : "+consonant);

    }
}