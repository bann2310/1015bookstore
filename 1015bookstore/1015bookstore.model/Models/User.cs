using _1015bookstore.model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1015bookstore.model.Models
{
    [Table("Users")]
    public class User: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string username { get; set; }

        [Required]
        [MaxLength(20)]
        [Column(TypeName = "varchar")]
        public string password { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string email { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string firstname { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string lastname { get; set; }

        [Required]
        [Column(TypeName = "text")]
        public string phone { get; set; }

        // Khóa ngoại với UserAddress
        public virtual ICollection<UserAddress> useraddresses { get; set;}
        // Khóa ngoại với Order
        public virtual ICollection<Order> orders { get; set;}
        // Khóa ngoại với Cart
        public virtual ICollection<Cart> carts { get; set;}
        // Khóa ngoại với CartItem
        public virtual ICollection<CartItem> cartitems { get; set;}
        // Khóa ngoại với Review
        public virtual ICollection<Review> reviews { get; set;}
        // Khóa ngoại với TypeUsers_UserTypes
        public virtual ICollection<TypedUsers_UserTypes> typedusers_usertypes { get; set;}
        // Khóa ngoại với TypedUsers_Promotionals
        public virtual ICollection<TypedUsers_Promotionals> typedusers_promotionals { get; set; }

    }
}
