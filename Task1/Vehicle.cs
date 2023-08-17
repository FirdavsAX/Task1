using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Vehicle
    {
        public int Year { get; set; }
        public decimal Price { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Year : {Year}");
            Console.WriteLine($"Price : {Price}");
        }
        public Vehicle(int year,decimal price)
        {
            Year = year;
            Price = price;
        }
    }
}
