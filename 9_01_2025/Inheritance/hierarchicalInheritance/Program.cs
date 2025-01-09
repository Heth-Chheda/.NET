using System;

class Base
{
    public void ShowMessage()
    {
        Console.WriteLine("Base Class Message");
    }
}
class child1 : Base
{
    public void Display()
    {
        ShowMessage();
        Console.WriteLine("Child 1 Message !");
    }
}
class child2 : Base
{
    public void Show()
    {
        ShowMessage();
        Console.WriteLine("child 2 Message !");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        //Implementing Hirarchical inheritance
        Console.WriteLine("Implementation of Hirarchical Inheritance !");

        //Creating the instance of child 1 : 
        child1 c1 = new child1();
        c1.Display();

        Console.ReadLine();

        //Creating the instance of Child 2
        child2 c2 = new child2();
        c2.Show();

        Console.ReadLine();
    }
}