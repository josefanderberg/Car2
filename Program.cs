using System;

internal class Program
{
    static void Main(string[] args)
    {
        Car ferrari = new Car();
        ferrari.Brand = "Ferrari";
        ferrari.Color = "Red";
        ferrari.MaxSpeed = 350;

        Car volvo = new Car();
        volvo.Brand = "Volvo";
        volvo.Color = "Blue";
        volvo.MaxSpeed = 230;

        ferrari.ShowInfo();
        ferrari.Drive();

        volvo.ShowInfo();
        volvo.Drive();

    }
}