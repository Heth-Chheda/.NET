using System;


class Maths
{
    private int age;
    public void getAge()
    {
        Console.WriteLine("\nPlease Enter Your Age : ");
        int Age = int.Parse(Console.ReadLine());
        setAge(Age);
    }
    public int setAge (int a)
    {
        age = a;
        return age;
    }
    public void showMessage()
    {
        Console.WriteLine($"\nThe Age that You Entered is : {age} ");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Demonstration of Encapsulation in OOPS.");
        Maths maths = new Maths();
        maths.getAge();
        maths.showMessage();
        Console.ReadLine();
    }
}