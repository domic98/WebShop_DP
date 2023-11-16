using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop_DP.Models
{
    public class Order
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy", ApplyFormatInEditMode = true)]
        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "Total price is required.")]
        [Column(TypeName = "decimal(7,2)")]
        public decimal Total { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50)]
        public string BillingFirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50)]
        public string BillingLastName { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [StringLength(50)]
        public string BillingPhone { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [StringLength(100)]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid.")]
        public string BillingEmail { get; set; }

        [Required(ErrorMessage = "Adress is required.")]
        [StringLength(150)]
        public string BillingAdress { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [StringLength(50)]
        public string BillingCity { get; set; }

        [Required(ErrorMessage = "Country  is required.")]
        [StringLength(50)]
        public string BillingCountry { get; set; }

        [Required(ErrorMessage = "Postal code  is required.")]
        [StringLength(20)]
        public string BillingZip { get; set; }

        public string Message { get; set; }

        // veza s tablicom AspNetUsers
        public string UserId { get; set; }

        [ForeignKey("OrderId")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }


    }
}


/*
 * 
   public class Order
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy", ApplyFormatInEditMode = true)]
        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "Total price is required.")]
        [Column(TypeName = "decimal(7,2)")]
        public decimal Total { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50)]
        public string ShippingFirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50)]
        public string ShippingLastName { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [StringLength(50)]
        public string ShippingPhone { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [StringLength(100)]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid.")]
        public string ShippingEmail { get; set; }

        [Required(ErrorMessage = "Adress is required.")]
        [StringLength(150)]
        public string ShippingAdress { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [StringLength(50)]
        public string ShippingCity { get; set; }

        [Required(ErrorMessage = "Country  is required.")]
        [StringLength(50)]
        public string ShippingCountry { get; set; }

        [Required(ErrorMessage = "Postal code  is required.")]
        [StringLength(20)]
        public string ShippingZip { get; set; }

        public string Message { get; set; }

        // veza s tablicom AspNetUsers
        public string UserId { get; set; }

        [ForeignKey("OrderId")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }


    }
}

 * */