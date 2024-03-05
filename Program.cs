// Program.cs
using System;
using System.Runtime.ConstrainedExecution;
using VehicleExample;

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", "Corolla", 2020, "XYZ123");

        Console.WriteLine(myCar.DisplayInfo());
    }
}