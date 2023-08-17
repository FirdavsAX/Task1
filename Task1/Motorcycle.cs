using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }
        public void Wheelie()
        {
            Console.WriteLine($"Motocycle is wheeling");
        }
        public Motorcycle(int year,decimal price,bool hasSideCar):
            base(year,price)
        {
            HasSideCar = hasSideCar;
        }
    }
}
