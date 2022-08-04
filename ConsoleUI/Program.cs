using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            var bearCat = new Car() { Year = 2015, Make = "Arctic Cat", Model = "BearCat 5000 XT", HasTrunk = true };
            var bigDog = new Motorcycle() { Year = 2006, Make = "Big Dog", Model = "K-9 Chopper", HasSideCart = false };
            Vehicle leon = new Car() { Year = 2014, Make = "Seat", Model = "Leon", HasTrunk = true };
            Vehicle bmw = new Motorcycle() { Year = 1929, Make = "BMW", Model = "R63", HasSideCart = false };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(bearCat);
            vehicles.Add(bigDog);
            vehicles.Add(leon);
            vehicles.Add(bmw);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year} | Make: {vehicle.Make} | Model: {vehicle.Model}");
            }

            // Call each of the drive methods for one car and one motorcycle
            Console.WriteLine($"{leon.Make} {leon.Model}");
            leon.DriveAbstract();
            leon.DriveVirtual();
            Console.WriteLine($"{bmw.Make} {bmw.Model}");
            bmw.DriveAbstract();
            bmw.DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}
