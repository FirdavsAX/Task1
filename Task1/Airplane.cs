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
        }
    }
}
