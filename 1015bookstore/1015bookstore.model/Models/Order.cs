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
    [Table("Orders")]
    public class Order : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public DateTime orderdate { get; set; }

        [Required]
        public bool deliveried { get; set; }

        [Required]
        public DateTime deliverydate { get; set; }

        [Required]
        public int user_id { get; set; }

        [ForeignKey("user_id")]
        public virtual User user { get; set; }

        [Required]
        public int address_id { get; set; }

        [ForeignKey("address_id")]
        public virtual UserAddress useraddress { get; set; }

        // Khóa ngoại với OrderDetail
        public virtual ICollection<OrderDetail> orderdetails { get; set; }
    }
}
