using System;

public interface IA
{
    void Walk();
}
public interface IB
{
    void Drive();
}
class C : IA, IB
{
    public void Walk()
    {
        Console.WriteLine("The man is Walking !");
    }
    public void Drive() { Console.WriteLine("The Man is Driving !"); }
}
class Program
{
    public static void Main(string[] args)
    {
        C c = new C();
        Console.WriteLine("Implementing the usage of Multiple Inheritance !");
        c.Walk();
        c.Drive();
        Console.ReadLine();
    }
}