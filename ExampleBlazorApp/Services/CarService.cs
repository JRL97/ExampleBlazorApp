﻿using ExampleBlazorApp.Models;
using System.Collections.Immutable;

namespace ExampleBlazorApp.Services
{
    public class CarService
    { 
        //public static CarImage FiestaImage = new CarImage(1, "Fiesta1.PNG", 1);

        public List<Car> getCars() 
        {
            var cars = new List<Car>();
            return new List<Car>();
        }

        public static readonly List<Car> Cars = new List<Car>();
        //{
        //    new()
        //    {
        //        Id = 1,
        //        Name = "Ford Fiesta",
        //        Description = "The new Ford Fiesta available with Hybrid Technology",
        //        Variation = Fiesta, 
        //    },
        //    new()
        //    {
        //        Id = 2,
        //        Name = "Audi A3 Saloon",
        //        Description = "A compact saloon designed with a sporty interior and cutting-edge technology",
        //        Variation = Audi1
        //    },
        //    new()
        //    {
        //        Id = 3,
        //        Name = "Lexus UX",
        //        Description = " Lexus UX self-charging hybrid - it's always ready to go, wherever your journey takes you.",
        //        Variation= Lexus1
        //    }
        //};
    }
}
