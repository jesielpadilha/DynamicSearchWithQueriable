using System.ComponentModel.DataAnnotations.Schema;

namespace DynamicSearchWithQueryable.Models
{
    [Table("Car")]
    public class Car
    {
        public Car(string manufacturer, string model, int year)
        {
            Id = Guid.NewGuid();
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
        }

        public Guid Id { get; private set; }    
        public string Manufacturer { get; private set; }    
        public string Model { get; private set; }    
        public int Year { get; private set; }    
    }
}