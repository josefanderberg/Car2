using System;

internal class Program
{
    static void Main(string[] args)
    {
        var ferrari = new Car("Ferrari", 
            "Red", 
            350, 
            450, 
            CarType.Gasoline);


        var volvo = new Car("Volvo", 
            "Blue", 
            230, 
            250, 
            CarType.Diesel);


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