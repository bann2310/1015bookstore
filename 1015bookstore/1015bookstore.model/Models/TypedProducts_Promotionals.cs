using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1015bookstore.model.Models
{
    [Table("TypedProducts_Promotionals")]
    public class TypedProducts_Promotionals
    {
        [Key]
        [Column(Order = 1)]
        public int product_id { get; set; }

        [ForeignKey("product_id")]
        public virtual Product product { get; set; }

        [Key]
        [Column(Order = 2)]
        public int promotional_id { get; set; }

        [ForeignKey("promotional_id")]
        public virtual PromotionalCodecs promotionalcodes { get; set; }

        [Required]
        public DateTime expirationdate { get; set; }
    }
}
