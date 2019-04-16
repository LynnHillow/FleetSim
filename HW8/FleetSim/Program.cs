using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.Class;
using FleetSim.Objects.Enum;


namespace FleetSim.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(); car1._Model = "Tesla";car1.Color = CarColors.blue;
            Car car2 = new Car(); car2._Model = "Cadillac";car2.Color = CarColors.white;
            Car car3 = new Car(); car3._Model = "Thunderbird";car3.Color = CarColors.white;
            Car car4 = new Car(); car4._Model = "Mercedes";car4.Color = CarColors.red;
            Car car5 = new Car(); car5._Model = "Mazda";car5.Color = CarColors.blue;
            Console.WriteLine("\n");

            Random rnd = new Random();
            Console.WriteLine("Cars in my Garage: ");
            Console.WriteLine("My first car: " + car1._Model +", Color:" + car1.Color + ", Vin: " + car1._Vin);
            Console.WriteLine("My second car " + car2._Model + ", Color " + car2.Color + ", Vin: " + car2._Vin);
            Console.WriteLine("My third car " + car3._Model + " , Color " + car3.Color + ", Vin: " + car3._Vin);
            Console.WriteLine("My fourth car " + car4._Model + ", Color " + car4.Color + ", Vin: " + car4._Vin);
            Console.WriteLine("My fifth car " + car5._Model + ", Color" + car5.Color + ", Vin: " + car5._Vin);
            Console.WriteLine("\n");

            for (int i = 0; i < 10; i++)
            {
                car1._Mileage += rnd.Next(5, 15000); car1.TuneUp();
                Console.WriteLine("Tesla Mileage " + car1._Mileage+ "  "  +  car1._LastServicedDate);
                car2._Mileage += rnd.Next(5, 15000); car2.TuneUp();
                Console.WriteLine("Cadillac Mileage " + car2._Mileage + "  " + car2._LastServicedDate);
                car3._Mileage += rnd.Next(5, 15000); car3.TuneUp();
                Console.WriteLine("Thunderbird Mileage " + car3._Mileage + "  " + car3._LastServicedDate);
                car4._Mileage += rnd.Next(5, 15000); car4.TuneUp();
                Console.WriteLine("Mercedes Mileage " + car4._Mileage + "  " + car4._LastServicedDate);
                car5._Mileage += rnd.Next(5, 15000); car5.TuneUp();
                Console.WriteLine("Mazda Mileage " + car5._Mileage + "  " + car5._LastServicedDate);
                Console.WriteLine("\n");
            }
        }

    }
}
