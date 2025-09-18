using System;

internal class Program
{
    static void Main(string[] args)
    {
        Car ferrari = new Car();
        ferrari.Brand = "Ferrari";
        ferrari.Color = "Red";
        ferrari.MaxSpeed = 350;
        ferrari.HorsePower = 450;
        ferrari.CarType = CarType.Gasoline;

        Car volvo = new Car();
        volvo.Brand = "Volvo";
        volvo.Color = "Blue";
        volvo.MaxSpeed = 230;
        volvo.HorsePower = 250;
        volvo.CarType = CarType.Diesel;

        ferrari.ShowInfo();
        ferrari.Drive();
        ferrari.Honk();
        ferrari.Fuel();
        ferrari.IsFasterThan(volvo);

        Console.WriteLine();
        
        volvo.ShowInfo();
        volvo.Drive();
        volvo.Honk();
        volvo.Fuel();
        volvo.IsFasterThan(ferrari);
    }
}