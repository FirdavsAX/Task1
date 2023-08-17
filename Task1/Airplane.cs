using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Airplane : AirVehicle
    {
        public bool HasBusinessClass { get; set; }
        public Airplane(int year,decimal price ,decimal fuelCapacity ,bool hasBusinessClass):
             base(year,price,fuelCapacity)
        {
            HasBusinessClass=hasBusinessClass;

            Console.WriteLine("Your airplane");
            DisplayInfo();

            Console.WriteLine("Fuel capaciity : " + FuelCapacity);
            Console.WriteLine("Has a business class : " + HasBusinessClass);
        }
    }
}
