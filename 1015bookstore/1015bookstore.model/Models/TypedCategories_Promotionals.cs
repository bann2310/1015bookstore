using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1015bookstore.model.Models
{
    [Table("TypedCategories_Promotionals")]
    public class TypedCategories_Promotionals
    {
        [Key]
        [Column(Order = 1)]
        public int category_id { get; set; }

        [ForeignKey("category_id")]
        public virtual Category category { get; set; }

        [Key]
        [Column(Order = 2)]
        public int promotional_id { get; set; }

        [ForeignKey("promotional_id")]
        public virtual PromotionalCodecs promotionalcodes { get; set; }

        [Required]
        public DateTime expirationdate { get; set; }
    }
}
