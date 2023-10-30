using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1015bookstore.model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        [Column(Order = 1)]
        public int order_id { get; set; }

        [ForeignKey("order_id")]
        public virtual Order order { get; set; }

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
