using System;
using System.ComponentModel;

class Base
{
    public void Show()
    {
        Console.WriteLine("This is the Meassage of Base Class !");
    }
}
class Child : Base
{
    public void Display()
    {
        Console.WriteLine("This is the Message Of child class !");
        Show();
    }
}
class Son : Child
{
    public void ShowMsg()
    {
            Console.WriteLine("This is the Message of Son class !");
            Display();
    }

}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Implementing Multilevel Inheritance !\n");
        Son son = new Son();
        son.ShowMsg();
        Console.ReadLine();
    }
}