﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop_DP.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public decimal Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public decimal Price { get; set; }

        [ForeignKey("ProductId")]
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }

        [ForeignKey("ProductId")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
