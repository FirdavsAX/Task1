using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public void StartEngine()
        {
            Console.WriteLine("Car is engine start");
        }
        public Car(int year,decimal price,int numberOfDoors) :
            base(year,price)
        {
             NumberOfDoors = numberOfDoors;
        }

    }
}
