using DynamicSearchWithQueryable.Models;
using Microsoft.EntityFrameworkCore;

namespace DynamicSearchWithQueryable.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }

    public static class DbInitializer
    {
        public static void Initialize(ApplicationContext context)
        {
            if (!context.Cars.Any())
            {
                if (File.Exists("./Data/database.csv"))
                {
                    string[] lines = File.ReadAllLines("./Data/database.csv");
                    if (lines is not null && lines.Any())
                    {
                        var carsInsert = lines
                            .Where(l => !string.IsNullOrEmpty(l))
                            .Select(line => new Car(line.Split(";")[0], line.Split(";")[1], int.Parse(line.Split(";")[2])))
                            .ToList();

                        context.Cars.AddRange(carsInsert);
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}