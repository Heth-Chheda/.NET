using System;

class Maths
{
    public int Add(int a , int b)
    {
        return a + b;
    }
    public int Add (int a , int b, int c)
    {  
        return a + b + c; 
    } 
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Implementing the Method Overloading !");
        //Creating the instance of the Maths class
        Maths m = new Maths();
        Console.WriteLine("Enter the First Number : ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Second Number : ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Third Number : ");
        int num3 = int.Parse(Console.ReadLine());

        //Adding up the Values taken from the user 
        // Addition of number 1 and number 2 
        Console.WriteLine("The Addition of First and Second Number : " + m.Add(num1, num2));
        Console.WriteLine("Adding Three Number Now !!");

        Console.WriteLine("The Additon of All the Three Number : " + m.Add(num1, num2, num3));
        Console.ReadLine();
    }
}