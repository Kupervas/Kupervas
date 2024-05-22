using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     class Car
    {
        private string Brand { get; set; }
        private string Model { get; set; }
        private int Year { get; set; }
        public Car(string _Brand, string _Model, int _Year) 
        {
            Brand = _Brand;
            Model = _Model;   
            Year = _Year;
        }
        public override string ToString()
        {
            return $"Brand: {Brand}, Model: {Model}, Year: {Year}";
        }

    }
    public class Salon
    {
        private Car currentCar;
        public void AddCar( string Brand,  string Model, int Year ) 
        {
            currentCar = new Car( Brand, Model, Year );
            Console.WriteLine("Car added successfully");

        }
        public void RemoveCar()
        {
            if (currentCar == null)
            {
                Console.WriteLine("No car to remove");
            }
            else
            {
                currentCar = null;
                Console.WriteLine("Car removed successfully.");
            }

        }
    }

}
