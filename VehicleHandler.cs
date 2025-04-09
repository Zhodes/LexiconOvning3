using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconOvning3
{
    class VehicleHandler
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        
       
        /*public void CreateNewVehicle()
        {
            vehicles.Add(new Vehicle());
        }*/

        public void ChangeModel(Vehicle vehicle, string model)
        {
            vehicle.Model = model;
        }

        public void ChangeBrand(Vehicle vehicle, string brand)
        {
            vehicle.Brand = brand;
        }

        public void ChangeWeight(Vehicle vehicle, int weight)
        {
            vehicle.Weight = weight;
        }

        public void ChangeYear(Vehicle vehicle, int year)
        {
            vehicle.Year = year;
        }
    }
}
