using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Helicopter : AirVehicle
    {
        public int NumberOfSeats { get; set; }
        public Helicopter(int year , decimal price, decimal fuelCapacity, int numberOfSeats)
            : base(year, price, fuelCapacity)
        {
            NumberOfSeats=numberOfSeats;
        }
    }
}
