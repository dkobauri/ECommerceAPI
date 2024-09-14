using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceAPI.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public required Order Order { get; set; } // Navigation property

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public required Product Product { get; set; } // Navigation property

        public int Quantity { get; set; } = 1; // Default to 1 item

        public decimal Price { get; set; } // Will store the price at the time of the order
    }
}
