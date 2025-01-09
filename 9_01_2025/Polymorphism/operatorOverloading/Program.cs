using System;

public class Calculator
{
    int number;

    public Calculator() { }
    public Calculator(int n)
    {
        number = n;
    }
    public static Calculator operator +(Calculator lhs, Calculator rhs) 
    {
        Calculator c3 = new Calculator(0);
        c3.number = lhs.number + rhs.number;
        return c3;
    }
    public void Display()
    {
        Console.WriteLine("The Number is : {0}", number);
    }
}


class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Implementing Operator Overloading !");


        // Creating the first Instance 
        Calculator Calc1 = new Calculator(200);
        //Displaying the Value of the First Number 
        Console.WriteLine("The First Number is : ");
        Calc1.Display();

        //Creating the second Instance
        Calculator Calc2 = new Calculator(100);
        //Displaying the Value of the Second Number
        Console.WriteLine("The Second Number is : ");
        Calc2.Display();


        //Creating the third Instance
        Calculator Calc3 = new Calculator();
        Calc3 = Calc1 + Calc2;

        Console.WriteLine("The Addition of the number is : ");
        Calc3.Display();
        Console.ReadLine();



    }
}