using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Disel : Car
    {
        public double MaxSpeed { get; set; }
        public Disel(int year,decimal price,int numberOfDoors,double maxSpeed) :
            base(year,price,numberOfDoors)
        {
            MaxSpeed = maxSpeed;
        }
    }
    class Toyota : Disel
    {
        public Toyota(int year,decimal price)
            : base(year,price,4,300.00)
        {
            Console.WriteLine("Your car brand : Toyota");
            DisplayInfo();
            Console.WriteLine("number of doors : " + NumberOfDoors);
            Console.WriteLine("max speed : " + MaxSpeed);
        }
    }
    class BMW : Disel
    {
        public BMW(int year, decimal price)
           : base(year, price, 2, 330.00)
        {
            Console.WriteLine("Your car brand : BMW");
            DisplayInfo();

            Console.WriteLine("number of doors : " + NumberOfDoors);
            Console.WriteLine("max speed : " + MaxSpeed);
        }
    }
}
