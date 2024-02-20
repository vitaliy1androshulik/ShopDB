using System.ComponentModel.DataAnnotations;

namespace ShopDB.Entities
{
    public class Worker
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Surname { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required, MaxLength(100)]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        public Shop Shop { get; set; }
        public int ShopId { get; set; }

        public Position Position { get; set; }
        public int PositionId { get; set; }
    }
}
