using System;

class Father
{
    //defining the Father 
    public string FatherName()
    {
        return "Father";
    }
}
class firstChild : Father
{
    public string ChildName()
    {
        return "Son 1";
    }
}
class Program
{
    public static void Main(string[] args)
    {
        firstChild son = new firstChild();
        Console.WriteLine("\nImplementing Single Inheritance !");
        Console.WriteLine("\nMy name is : "+ son.ChildName() + "\nMy Father's Name is : " +son.FatherName() );
        Console.ReadLine();
    }
}