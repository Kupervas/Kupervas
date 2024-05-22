using ConsoleApp2;
using Microsoft.VisualBasic;
using System;

Salon cars = new Salon();
    Console.WriteLine("Choose the option");
    Console.WriteLine("1.Add car");
    Console.WriteLine("2.Remove car");
string Choice = Console.ReadLine();
switch (Choice) 
    {
        case "1":
        AddCar(cars);
            break;
        case "2":
        RemoveCar(cars);
            break;
    }
     static void AddCar(Salon Car)
{
    Console.WriteLine("Введіть марку авто");
    string Brand = Console.ReadLine();
    Console.WriteLine("Введіть модель авто");
    string Model = Console.ReadLine();
    Console.WriteLine("Введіть рік виготовлення авто");
    int.TryParse(Console.ReadLine(), out int Year);
}
     static void RemoveCar(Salon cars)
      {
        cars.RemoveCar();
      }
  


