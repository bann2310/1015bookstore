using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1015bookstore.model.Models
{
    [Table("ProductDetails")]
    public class ProductDetail
    {
        [Required]
        [Key]
        public int product_id { get; set; }

        [ForeignKey("product_id")]
        public virtual Product product { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string brand { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string suppiler { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string author { get; set; }
    }
}
