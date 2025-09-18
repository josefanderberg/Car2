using System;

internal class Car
{
    public string Brand = "";
    public string Color = "";
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

    public void Honk()
    {
        Console.WriteLine($"TUUUUUUT");
    }

    public void Fuel()
    {
        Console.WriteLine($"Car is of type: {CarType}");
        switch (CarType)
        {
            case CarType.Gasoline:
                Console.WriteLine("Fueling with gasoline");
                break;
            case CarType.Diesel:
                Console.WriteLine("Fueling with diesel");
                break;
            case CarType.Electric:
                Console.WriteLine("Charging the battery");
                break;
            case CarType.Hybrid:
                Console.WriteLine("Using both gasoline and electric power");
                break;
            default:
                Console.WriteLine("Unknown car type");
                break;
        }
    }
    public void IsFasterThan(Car otherCar)
    {
        if(otherCar.MaxSpeed > MaxSpeed)
        {
            Console.WriteLine($"{otherCar.Brand} is faster than {Brand}");
        }
        else if(otherCar.MaxSpeed < MaxSpeed)
        {
            Console.WriteLine($"{Brand} is faster than {otherCar.Brand}");
        }
        else
        {
            Console.WriteLine($"{Brand} and {otherCar.Brand} have the same speed");
        }
    }
}