using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };
            /* LINQ query
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year== 2010
                       select car;
                       */
            /*var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;
                              */
            //LINQ method
            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
            //var orderedCars = myCars.OrderByDescending(p => p.Year);
            var FistBMW = myCars.First(p => p.Make == "BMW");
            Console.WriteLine(FistBMW.VIN);


            /*foreach (var cars in orderedCars)
            {
                Console.WriteLine("{0} {1} {2}", cars.Year, cars.Model, cars.VIN);
            }
            */
            Console.ReadLine();

        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
