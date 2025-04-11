using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconOvning3;

class Motorcycle : Vehicle
{
    public Motorcycle()
    {
        HasSideCar = false;
        VehicleType = "Motorcycle";
    }
    public Motorcycle(string brand, string model, int year, double weight, bool hasSideCar) : base(brand, model, year, weight)
    {
        HasSideCar = hasSideCar;
        VehicleType = "Motorcycle";
    }

    bool HasSideCar { get; set; }

    public override void Stats()
    {
        base.Stats();
        Console.WriteLine($"Has sidecar: {(HasSideCar ? "yes" : "no")}");
    }

    public override void StartEngine()
    {
        Console.WriteLine("BRAAAAAP");
    }
}
