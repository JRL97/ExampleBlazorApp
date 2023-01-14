using ExampleBlazorApp.Data;
using ExampleBlazorApp.Models;
using System.Collections.Immutable;


namespace ExampleBlazorApp.Services
{
    public class CarService
    {
        private static ApplicationDbContext _context;

        public CarService(ApplicationDbContext db)
        {
            _context = db;
        }

        //public static readonly List<Car> Cars = new List<Car>();
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
        public static List<Car> GetProducts()
        {
            return _context.Cars.ToList();
        }

        public static Car GetCar(int id)
        {
            return _context.Cars.Find(id);
        }

        // Other CRUD Operations

        // public void DeleteCar(int id);
        // public void AddCar(Car car);
        // public void UpdateCar(int id, Car car);
    }
}
