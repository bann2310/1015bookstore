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
    [Table("UserTypes")]
    public class UserType : Auditable
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
        [MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string description { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string createdby { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string updatedby { get; set; }

        // Khóa ngoại với TypeUsers_UserTypes
        public virtual ICollection<TypedUsers_UserTypes> typedusers_usertypes { get; set; }
        // Khóa ngoại với TypedUserTypes_Promotionals
        public virtual ICollection<TypedUserTypes_Promotionals> typedusertypes_promotionals { get; set; }
    }
}
