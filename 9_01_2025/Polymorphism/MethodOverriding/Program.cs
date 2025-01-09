using System;


public class Drawing
{
    public virtual double Area(double i)
    {
        return 0;
    }
}

public class Circle : Drawing
{
    public override double Area(double Radius)
    {
        return Math.PI * Radius * Radius;
    }
}
public class Square : Drawing
{
    public override double Area(double Length)
    {
        return Length * Length;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Implementing Method Over riding !!!!");

        //For Circle
        Console.WriteLine("Enter the Radius of the Circle : ");
        double radius = double.Parse(Console.ReadLine());
        Drawing circle = new Circle();
        Console.WriteLine("The Area of the CIrcle is : " + circle.Area(radius));


        //For Square
        Console.WriteLine("Enter the Length of the Square : ");
        double length = double.Parse(Console.ReadLine());
        Drawing square = new Square();
        Console.WriteLine("The Area of the Square is : "+ square.Area(length));

        Console.ReadLine();
    }
}