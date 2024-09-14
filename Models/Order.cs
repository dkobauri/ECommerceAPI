using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceAPI.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public required DateTime OrderDate { get; set; }

        [Required]
        public required decimal TotalAmount { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public required User User { get; set; } // Navigation property

        public ICollection<OrderItem>? OrderItems { get; set; } = new List<OrderItem>(); // Nullable, since an order might not have items initially
    }
}
