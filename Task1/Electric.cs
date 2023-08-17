using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task1
{
    internal class Electric : Car
    {
        public decimal BatteryCapacity { get; set; }
        public void ChargeBattery()
        {
            Console.WriteLine("Battery is charged");
        }
        public Electric(int year,decimal price,int numberOfDoors,decimal batteryCapacity)
            :base(year,price,numberOfDoors)
        {
            BatteryCapacity=batteryCapacity;
        }
    }
    class Tesla : Electric 
    {
        public Tesla(int year,decimal price,decimal batteryCapacity  ):
            base(year, price, 2, batteryCapacity)
        {
            Console.WriteLine("Your tesla car");
            DisplayInfo();
            Console.WriteLine("Battery capacity : " + BatteryCapacity);
            Console.WriteLine("Number of doors : " + NumberOfDoors);
        }
    }
    class Wolswagen: Electric
    {
        public Wolswagen(int year, decimal price, decimal batteryCapacity) :
            base(year, price, 4, batteryCapacity)
        {
            Console.WriteLine("Your Wolswagen car");
            DisplayInfo();
            Console.WriteLine("Battery capacity : " + BatteryCapacity);
            Console.WriteLine("Number of doors : " + NumberOfDoors);
        }
    }
}
