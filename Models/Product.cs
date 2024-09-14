using System.ComponentModel.DataAnnotations;

namespace ECommerceAPI.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        public string? Description { get; set; } // Nullable, optional field

        [Required]
        public required decimal Price { get; set; }

        public string? ImageUrl { get; set; } // Nullable, optional field
    }
}