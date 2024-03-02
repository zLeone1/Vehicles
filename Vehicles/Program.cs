using System;
using Vehicles;




Car myCar = new Car("Toyota", "Corolla", "Red");

myCar.ShowInfo();

public class Car : Vehicle
{
    public string Color { get; set; }

    public Car(string brand, string model, string color) : base (brand, model) 
    {
        Color = color;
       
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Color: {Color}");
    }