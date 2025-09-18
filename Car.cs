using System;

internal class Car
{
    public string Brand;
    public string Color;
    public int MaxSpeed;

    public void ShowInfo()
    {
        Console.WriteLine($"Brand:  {Brand}, Color: {Color}, MaxSpeed: {MaxSpeed}");
    }
    public void Drive()
    {
        Console.WriteLine($"The {Brand} car is driving");
    }
}