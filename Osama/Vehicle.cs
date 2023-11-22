using System;
using System.Collections.Generic;
namespace Osama
{
    public class Vehicle
    {
        public string PlateNumber { get; set; }
        public string LicenseNumber { get; set; }


        public void Honk()
        {
            Console.WriteLine("Tutu");
        }

        public void Accelerate()
        {
            Console.WriteLine("The Vehicle is Accelerating...");
        } 

        public void Break()
        {
            Console.WriteLine("The Vehicle has stopped.");
        }
    }
}
