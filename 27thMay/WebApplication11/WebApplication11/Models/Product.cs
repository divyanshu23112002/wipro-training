using System.ComponentModel.DataAnnotations;

namespace WebApplication11.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}