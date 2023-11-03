using _1015bookstore.web.Data.Abstract;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _1015bookstore.web.Data.Entity
{
    [Table("Products")]
    public class Product : Auditable
    {
        public int id { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string name { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string alias { get; set; }

        public int category_id { get; set; }

        public virtual Category category { get; set; }

        public string image { get; set; }

        public string more_image { get; set; }

        [Range(0, float.MaxValue)]
        public float price { get; set; }

        [Range(0, float.MaxValue)]
        public float? starts { get; set; }

        [Range(0, int.MaxValue)]
        public int? reviews { get; set; }

        [Range(0, int.MaxValue)]
        public int? buy_count { get; set; }

        public bool? flashsale { get; set; }

        public int? like_count { get; set; }

        [Range(0, int.MaxValue)]
        public int waranty { get; set; }

        [Range(0, int.MaxValue)]
        public int quanity { get; set; }

        [Range(0, int.MaxValue)]
        public int? view_count { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string description { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string createdby { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string updatedby { get; set; }

        public virtual ProductDetail productdetail { get; set; }
        
        // Khóa ngoại với OrderDetail
        public virtual ICollection<OrderDetail> orderdetails { get; set; }
        // Khóa ngoại với CartItem
        public virtual ICollection<CartItem> cartitems { get; set; }
        // Khóa ngoại với Review
        public virtual ICollection<Review> reviews_ { get; set; }
        // Khóa ngoại với TypedProducts_Promotionals
        public virtual ICollection<TypedProducts_Promotionals> typedproducts_promotionals { get; set; }


        public Product()
        {
            cartitems = new List<CartItem>();
            orderdetails = new List<OrderDetail>();
            reviews_ = new List<Review>();
            typedproducts_promotionals = new List<TypedProducts_Promotionals>();
        }
    }
}
