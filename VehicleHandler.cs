using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconOvning3;

static class VehicleHandler
{
    static public List<Vehicle> vehicles = new List<Vehicle>();

    static public void createNewVehicle()
    {
        Vehicle vehicle;
        bool validInput = false;
        do
        {
            string brand;
            string model;
            int year;
            double weight;
            Console.WriteLine("What type of vehicle would you like to create?\n \n 1: Car\n 2: Truck\n 3: Motorcycle\n 4: ElectricScooter");
            string menuSelection = Console.ReadLine();
            Console.WriteLine("");
            switch (menuSelection)
            {
                case "1":
                    vehicle = new Car();
                    populateVehicleValues(vehicle);
                    validInput = true;
                    break;
                case "2":

                    vehicle = new Truck();
                    populateVehicleValues(vehicle);
                    validInput = true;
                    break;
                case "3":
                    vehicle = new Motorcycle();
                    populateVehicleValues(vehicle);
                    validInput = true;
                    break;
                case "4":
                    vehicle = new ElectricScooter();
                    populateVehicleValues(vehicle);
                    validInput = true;
                    break;
                default:
                    Console.WriteLine("InvalidInput, try again");
                    break;
            }
        }
        while (!validInput);

        Console.WriteLine("Vehicle succesfully created!\n");


    }





    static private void populateVehicleValues(Vehicle vehicle)
    {
        bool validBrandInput = false;
        do
        {

            Console.WriteLine("Enter the vehicles brand:");
            try
            {
                vehicle.Brand = Console.ReadLine();
                validBrandInput = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        while (!validBrandInput);

        bool validModelInput = false;
        do
        {

            Console.WriteLine("Enter the vehicles model:");
            try
            {
                vehicle.Model = Console.ReadLine();
                validModelInput = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        while (!validModelInput);



        bool validYearInput = false;
        do
        {

            Console.WriteLine("Enter the vehicles year of manufacture:");
            int year = 0;
            if (int.TryParse(Console.ReadLine(), out year))
            {
                try
                {
                    vehicle.Year = year;
                    validYearInput = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Your input must only contain an integer, try again.");
            }
        }
        while (!validYearInput);

        bool validWeightInput = false;
        do
        {

            Console.WriteLine("Enter the weight of the vehicle in kg:");
            double weight = 0;
            if (double.TryParse(Console.ReadLine(), out weight))
            {
                try
                {
                    vehicle.Weight = weight;
                    validWeightInput = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Your input must only contain a number, try again.");
            }
        }
        while (!validWeightInput);


        Console.WriteLine("");

        

        //return brand;
    }

    static public void ChangeModel(Vehicle vehicle, string model)
    {
        vehicle.Model = model;
    }

    static public void ChangeBrand(Vehicle vehicle, string brand)
    {
        vehicle.Brand = brand;
    }

    static public void ChangeWeight(Vehicle vehicle, int weight)
    {
        vehicle.Weight = weight;
    }

    static public void ChangeYear(Vehicle vehicle, int year)
    {
        vehicle.Year = year;
    }

    //static public void ListVehicles()
    //{
    //    foreach (Vehicle vehicle in vehicles)
    //    {
    //        vehicle.Stats();
    //        vehicle.StartEngine();
    //        if (vehicle is Icleanable)
    //        {
    //            Icleanable icleanableVehicle = (Icleanable)vehicle;
    //            icleanableVehicle.Clean();

    //        }
    //    }
    //}

    static public void ListVehicles()
    {
        ListVehicles(vehicles);
    }

    static public void ListVehicles(List<Vehicle> vehicleList)
    {
        int vehicleCount = 0;
        foreach (Vehicle vehicle in vehicleList)
        {
            vehicleCount++;
            Console.WriteLine($"{vehicleCount}. VehicleType: {vehicle.VehicleType}");
            vehicle.Stats();
            vehicle.StartEngine();
            if (vehicle is Icleanable)
            {
                Icleanable icleanableVehicle = (Icleanable)vehicle;
                icleanableVehicle.Clean();

            }
            Console.WriteLine("");
        }
    }
}
