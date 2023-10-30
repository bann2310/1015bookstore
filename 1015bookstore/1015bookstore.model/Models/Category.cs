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
    [Table("Categories")]
    public class Category : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string name { get; set; }

        [Required]
        public int parent_id { get; set; }

        [ForeignKey("parent_id")]
        public virtual Category category { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string createdby { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string updatedby { get; set; }
        
        // Khóa ngoại với Category
        public virtual ICollection<Category> categories { get; set;}
        // Khóa ngoại với Product
        public virtual ICollection<Product> products { get; set; }
        // Khóa ngoại với TypedCategories_Promotionals
        public virtual ICollection<TypedCategories_Promotionals> typedcategories_promotionals { get; set; }


    }
}
