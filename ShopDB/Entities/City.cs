using System.ComponentModel.DataAnnotations;

namespace ShopDB.Entities
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }

        public Country Country { get; set; }

        public int CountryId { get; set; } // Foreign key

        public ICollection<Shop> Shops { get; set; } //Navigation
    }
}
