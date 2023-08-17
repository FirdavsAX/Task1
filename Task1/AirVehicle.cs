using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class AirVehicle : Vehicle
    {
        public decimal  FuelCapacity { get; set; }
        public void Fly()
        {
            Console.WriteLine("Air vehicle is flying");
        }
        public AirVehicle(int year, decimal price, decimal fuelCapacity):
            base(year, price)
        {
            FuelCapacity = fuelCapacity;
        }
    }
}
