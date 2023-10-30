using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1015bookstore.model.Models
{
    [Table("TypedUsers_UserTypes")]
    public class TypedUsers_UserTypes
    {
        [Key]
        [Column(Order = 1)]
        public int user_id { get; set; }

        [ForeignKey("user_id")]
        public virtual User user { get; set; }

        [Key]
        [Column(Order = 2)]
        public int usertype_id {  get; set; }

        [ForeignKey("usertype_id")]
        public virtual UserType usertype { get; set; }

        [Required]
        public DateTime expirationdate { get; set; }
    }
}
