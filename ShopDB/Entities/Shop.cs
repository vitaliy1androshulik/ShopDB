using System.ComponentModel.DataAnnotations;

namespace ShopDB.Entities
{
    public class Shop
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Address { get; set; }
        public City City { get; set; }//вказівник
        public int CityId { get; set; }//сам ключик
        public ICollection<Product> Products { get; set; }
        public ICollection<Worker> Workers { get; set; }
        public int? ParkingArea { get; set; }

    }
}
