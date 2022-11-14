using System;
namespace ProductPrice;

class Program
{
    public static void Main(string[] args)
    {
        //get the product price from the user
        Console.WriteLine("Enter the Price of the Product");
        int productPrice = int.Parse(Console.ReadLine());

        //tax calculation
        float taxOfProduct = productPrice * 0.18f;

        //display the total cost of the product
        Console.WriteLine($"Total Price of the Product with tax is : {productPrice + taxOfProduct}");
    }
}