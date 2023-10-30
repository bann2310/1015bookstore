using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1015bookstore.model.Models
{
    [Table("Reviews")]
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public int user_id { get; set; }

        [ForeignKey("user_id")]
        public virtual User user { get; set; }

        [Required]
        public int product_id { get; set; }

        [ForeignKey("product_id")]
        public virtual Product product { get; set; }

        [Required]
        public int starts {  get; set; }

        [Required]
        [Column(TypeName="ntext")]
        public string contents { get; set; }

        [Required]
        public bool status { get; set; }

        [Required]
        public DateTime createdtime { get; set; }

        [Required]
        public DateTime deletedtime { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string deletedby {  get; set; }


    }
}
