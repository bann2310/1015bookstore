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
    [Table("UserAddresses")]
    public class UserAddress: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public int user_id { get; set; }

        [ForeignKey("user_id")]
        public virtual User user { get; set; }

        [Required]
        public bool is_default { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string receiver_name { get; set; }

        [Required]
        [Column(TypeName = "text")]
        public string receiver_phone { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string city { get; set;}

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string district { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string sub_district { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string address_detail { get; set; }

        [Required]
        public float coordinates_X { get; set; }

        [Required]
        public string coordinates_Y { get; set; }


        // Khóa ngoại với Order
        public virtual ICollection<Order> orders { get; set; }
    }
}
