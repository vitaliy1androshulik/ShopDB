using System.ComponentModel.DataAnnotations;

namespace ShopDB.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Discount { get; set; }
        public Category Category { get; set; }
        public int? CetegoryId { get; set; }
        public ICollection<Shop> Shops { get; set; }
        public int Quantity { get; set; }
        public bool IsInStock { get; set; }
    }
}
