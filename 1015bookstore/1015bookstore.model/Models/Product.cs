using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1015bookstore.model.Abstract;
using System.Xml.Linq;

namespace _1015bookstore.model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string name { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string alias { get; set; }

        [Required]
        public int category_id { get; set; }

        [ForeignKey("category_id")]
        public virtual Category category { get; set; }

        [Required]
        public string image { get; set; }

        [Required]
        public XElement more_image { get; set; }

        [Required]
        public float price { get; set; }

        public float? starts { get; set; }

        public int? reviews { get; set; }

        public int? buy_count { get; set; }

        [Required]
        public bool flashsale { get; set; }

        public int? like_count { get; set; }

        [Required]
        public int waranty { get; set; }

        [Required]
        public int quanity { get; set; }

        public int? view_count { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string description {  get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string createdby { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string updatedby { get; set; }

        // Khóa ngoại với ProductDetail
        public virtual ICollection<ProductDetail> productdetails { get; set; }
        // Khóa ngoại với OrderDetail
        public virtual ICollection<OrderDetail> orderdetails { get; set; }
        // Khóa ngoại với CartItem
        public virtual ICollection<CartItem> cartitems { get; set; }
        // Khóa ngoại với Review
        public virtual ICollection<Review> reviews_ { get; set; }
        // Khóa ngoại với TypedProducts_Promotionals
        public virtual ICollection<TypedProducts_Promotionals> typedproducts_promotionals { get; set; }

    }
}
