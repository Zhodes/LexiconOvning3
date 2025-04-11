using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconOvning3
{
    static class Utilities
    {
        static string invalidInputAns = "\nInvalid input, try again\n";

        public static void MainMenu()
        {

            bool exitProgram = false;
            do
            {
                Console.WriteLine("Main Menu\n \n 1: Create vehicle\n 2: list all vehicles\n 3: List SystemErrors\n 4: Example Vehicle List\n 0: Avsluta program ");
                string menuSelection = Console.ReadLine();
                Console.WriteLine("");
                switch (menuSelection)
                {
                    case "1":
                        VehicleHandler.createNewVehicle();
                        break;
                    case "2":
                        VehicleHandler.ListVehicles();
                        break;
                    case "3":
                        SystemError.PrintSystemErrors();
                        break;
                    case "4":
                        List<Vehicle> exampleListOfVehicles = new List<Vehicle>() { new Car("Volvo", "S40", 2002, 1220, 5), new Truck("Volvo", "FE", 2006, 2600, 44000), new Motorcycle("Harley-Davidson", "Fat Boy", 1990, 320, false), new ElectricScooter("Segway", "Ninebot F20D", 2020, 16, 20) };
                        VehicleHandler.ListVehicles(exampleListOfVehicles);
                        break;
                    case "0":
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine(invalidInputAns);
                        break;
                }
                Console.WriteLine();
            }
            while (!exitProgram);
        }
    }
}
