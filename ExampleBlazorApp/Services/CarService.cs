using ExampleBlazorApp.Models;
using System.Collections.Immutable;

namespace ExampleBlazorApp.Services
{
    public class CarService
    {
        public static CarVariation Fiesta = new CarVariation("Blue", 1200, 18495);
        public static CarVariation Audi1 = new CarVariation("Black", 1400, 28585);
        public static CarVariation Lexus1 = new CarVariation("Green", 2200, 34750);

        public static readonly List<Car> Cars = new List<Car>()
        {
            new()
            {
                Id = 1,
                Name = "Ford Fiesta",
                Description = "The new Ford Fiesta available with Hybrid Technology",
                Variation = Fiesta
            },
            new()
            {
                Id = 2,
                Name = "Audi A3 Saloon",
                Description = "A compact saloon designed with a sporty interior and cutting-edge technology",
                Variation = Audi1
            },
            new()
            {
                Id = 3,
                Name = "Lexus UX",
                Description = " Lexus UX self-charging hybrid - it's always ready to go, wherever your journey takes you.",
                Variation= Lexus1
            }
        };
    }
}
