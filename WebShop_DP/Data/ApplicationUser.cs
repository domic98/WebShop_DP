using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebShop_DP.Models;

namespace WebShop_DP.Data
{
    public class ApplicationUser : IdentityUser

    {
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength (150)]
        public string Adress { get; set; }


        [ForeignKey("UserId")]

       public virtual ICollection<Order> Orders { get; set; }
    }
}
