using ConsoleApp2;
using System;

Salon cars = new Salon();
bool running = true; 

while(running)
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
     static void AddCar(Salon cars)
{
    Console.WriteLine("Введіть марку авто");
    string Brand = Console.ReadLine();
    Console.WriteLine("Введіть модель авто");
    string Model = Console.ReadLine();
    Console.WriteLine("Введіть рік виготовлення авто");
    int Year = Console.ReadLine();
    
        static void RemoveCar(Salon cars)
    {
    cars.RemoveCar();
    }
}
  


