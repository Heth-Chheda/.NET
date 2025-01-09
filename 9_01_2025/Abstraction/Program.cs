using System;
using System.IO;

// Implementation of Avbstraction ....................

class Program
{
    abstract class vehicles
    {
        public abstract void rideCar();
        public void infoVehicle()
        {
            Console.WriteLine("\nYou Tried to access the Information about the Vehicle \nBut I am Riding the Car !");
        } 
    }
    class Car : vehicles
    {
        public override void rideCar()
        {
            Console.WriteLine("\nYuppie ! I am Riding the Car !!");
        }
        public Car()
        {
            Console.WriteLine(" \nThis Class will implement the abstract class ! \nHello! I am a car.");
            }
    }

    public static void Main(String[] args)
    {
        Car myCar = new Car();
        myCar.rideCar();
        myCar.infoVehicle();
        Console.ReadLine();
    }
}
