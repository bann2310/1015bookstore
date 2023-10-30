using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1015bookstore.model.Models
{
    [Table("CartItems")]
    public class CartItem
    {
        [Key]
        [Column(Order = 1)]
        public int user_id { get; set; }

        [ForeignKey("user_id")]
        public virtual User user { get; set; }

        [Key]
        [Column(Order = 2)]
        public int product_id { get; set; }

        [ForeignKey("product_id")]
        public virtual Product product { get; set; }

        [Required]
        public int quantity { get; set; }

        [Required]
        public float price { get; set; }

    }
}
