using ExampleBlazorApp.Models;

namespace ExampleBlazorApp.Data
{
    public static class DataSeeding
    {
        //public static CarVariation Fiesta = new CarVariation("Blue", 1200, 18495);
        //public static CarVariation Audi1 = new CarVariation("Black", 1400, 28585);
        //public static CarVariation Lexus1 = new CarVariation("Green", 2200, 34750);
        public static void Initialise(ApplicationDbContext db)
        {
            SeedCars(db);
            SeedImages(db);
        }
        private static void SeedImages(ApplicationDbContext db)
        {
            //throw new NotImplementedException();
        }

        private static void SeedCars(ApplicationDbContext db)
        {
            if (db.Cars.Any())
            {
                return;
            }
            var cars = new Car[]
            {
                new()
                {
                    Make = "Ford",
                    Model = "Fiesta",
                    Name = "EcoBoost",
                    Colour = "Red",
                    EngineSize = 1000,
                    Price = 18495,
                },
                 new()
                {
                    Make = "Ford",
                    Model = "Fiesta",
                    Name = "EcoBoost",
                    Colour = "Black",
                    EngineSize = 1000,
                    Price = 18495,
                },
                  new()
                {
                    Make = "Ford",
                    Model = "Fiesta",
                    Name = "EcoBoost",
                    Colour = "Blue",
                    EngineSize = 1000,
                    Price = 18495,
                },
                   new()
                {
                    Make = "Ford",
                    Model = "Fiesta",
                    Name = "EcoBoost Hybrid",
                    Colour = "White",
                    EngineSize = 1000,
                    Price = 22449,

                },
                    new()
                {
                    Make = "Ford",
                    Model = "Fiesta",
                    Name = "EcoBoost Hybrid",
                    Colour = "Blue",
                    EngineSize = 1000,
                    Price = 22449,

                },
                     new()
                {
                    Make = "Ford",
                    Model = "Fiesta",
                    Name = "EcoBoost Hybrid",
                    Colour = "Green",
                    EngineSize = 1000,
                    Price = 22459,

                },
                      new()
                {
                    Make = "Ford",
                    Model = "Fiesta",
                    Name = "EcoBoost",
                    Colour = "Red",
                    EngineSize = 1500,
                    Price = 29950,

                },
                       new()
                {
                    Make = "Ford",
                    Model = "Fiesta",
                    Name = "EcoBoost",
                    Colour = "White",
                    EngineSize = 1500,
                    Price = 29950,

                },
                        new()
                {
                    Make = "Ford",
                    Model = "Fiesta",
                    Name = "EcoBoost",
                    Colour = "Black",
                    EngineSize = 1500,
                    Price = 29950,

                },
                         new()
                {
                    Make = "Ford",
                    Model = "Fiesta",
                    Name = "EcoBoost",
                    Colour = "Silver",
                    EngineSize = 1000,
                    Price = 18495,

                },
           };
            db.Cars.AddRange(cars);
            db.SaveChanges();
        }
    }
}
