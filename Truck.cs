using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconOvning3;

class Truck : Vehicle, Icleanable
{
    public Truck()
    {
        CargoCapacity = 100;
        VehicleType = "Truck";
    }
    public Truck(string brand, string model, int year, double weight, int cargoCapacity) : base(brand, model, year, weight)
    {
        CargoCapacity = cargoCapacity;
        VehicleType = "Truck";
    }

    int CargoCapacity { get; set; }

    public override void Stats()
    {
        base.Stats();
        Console.WriteLine($"Cargo capacity: {CargoCapacity} kg");
    }

    public override void StartEngine()
    {
        Console.WriteLine("BBRBRRRRHHHHRRHHGGGRGRGRGRRRRRRR");
    }

    public void Clean()
    {
        Console.WriteLine($"The {this.ToString()} has been cleaned");
    }
}
