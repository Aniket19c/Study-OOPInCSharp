using System;

interface IVehicle
{
    void Start();
}

abstract class Vehicle
{
    public string Model { get; set; }
    public Vehicle(string model)
    {
        Model = model;
    }
    public abstract void Drive();
}

class Car : Vehicle, IVehicle
{
    public Car(string model) : base(model) { }
    public override void Drive()
    {
        Console.WriteLine("Car is driving");
    }
    public void Start()
    {
        Console.WriteLine("Car has started");
    }
}

class Bike : Vehicle
{
    public Bike(string model) : base(model) { }
    public override void Drive()
    {
        Console.WriteLine("Bike is driving");
    }
}

class Program
{
    static void Main()
    {
        IVehicle car = new Car("Sedan");
        car.Start();
        Vehicle myCar = new Car("Sedan");
        myCar.Drive();
        Vehicle myBike = new Bike("Sport");
        myBike.Drive();
    }
}
