namespace LexiconOvning3;

class ElectricScooter : Vehicle
{
    public ElectricScooter()
    {
        BatteryRange = 10;
        VehicleType = "ElectricScooter";
    }
    public ElectricScooter(string brand, string model, int year, double weight, int batteryRange) : base(brand, model, year, weight)
    {
        BatteryRange = batteryRange;
        VehicleType = "ElectricScooter";
    }
    
    int BatteryRange { get; set; }

    public override void Stats()
    {
        base.Stats();
        Console.WriteLine($"Battery range: {BatteryRange} km");
    }

    public override void StartEngine()
    {
        Console.WriteLine("HHIIIEEEEEEEE");
    }
}
