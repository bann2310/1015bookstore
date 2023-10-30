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
    [Table("Carts")]
    public class Cart : Auditable
    {
        [Key]
        public int user_id { get; set; }

        [ForeignKey("user_id")]
        public virtual User user { get; set; }




    }
}
