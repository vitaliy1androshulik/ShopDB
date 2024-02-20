using System.ComponentModel.DataAnnotations;

namespace ShopDB.Entities
{
    public class Position
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        public ICollection<Worker> Workers { get; set; }
    }
}
