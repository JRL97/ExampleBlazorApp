using ExampleBlazorApp.Models;
using System.Collections.Immutable;

namespace ExampleBlazorApp.Services
{
    public class ProductService
    {
        public static readonly List<Product> Products = new List<Product>()
        {
            new()
            {
                Id = 1,
                Name = "Ford Fiesta",
                Description = "The new Ford Fiesta available with Hybrid Technology",
                Price = 18495
            },
            new()
            {
                Id = 2,
                Name = "Audi A3 Saloon",
                Description = "A compact saloon designed with a sporty interior and cutting-edge technology",
                Price = 28585
            },
            new()
            {
                Id = 3,
                Name = "Lexus UX",
                Description = " Lexus UX self-charging hybrid - it's always ready to go, wherever your journey takes you.",
                Price = 34750
            }
        };
    }
}
