namespace LexiconOvning3;

class Car : Vehicle, Icleanable
{
    public Car()
    {
        MaxPassangers = 5;
        VehicleType = "Car";
    }
    public Car(string brand, string model, int year, double weight, int maxPassangers) : base(brand, model, year, weight)
    {
        MaxPassangers = maxPassangers;
        VehicleType = "Car";
    }

    int MaxPassangers { get; set; }

    public override void StartEngine()
    {
        Console.WriteLine("Vrooom");
    }

    public override void Stats()
    {
        base.Stats();
        Console.WriteLine($"Max number of Passanger: {MaxPassangers}");
    }



    public void Clean()
    {
        Console.WriteLine($"The {this.ToString()} has been cleaned");
    }
}
