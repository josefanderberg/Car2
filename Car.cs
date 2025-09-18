using System;

internal class Car
{
    public string Brand;
    public string Color;
    public int MaxSpeed;
    public int HorsePower;
    public CarType CarType;


    public void ShowInfo()
    {
        Console.WriteLine($"Brand:  {Brand}, Color: {Color}, MaxSpeed: {MaxSpeed}, HorsePower: {HorsePower}");
    }
    public void Drive()
    {
        Console.WriteLine($"The {Brand} car is driving");
    }
}