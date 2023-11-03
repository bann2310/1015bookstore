using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _1015bookstore.web.Data.Entity
{
    [Table("Reviews")]
    public class Review
    {
        public int id { get; set; }

        public int user_id { get; set; }

        public virtual User user { get; set; }

        public int product_id { get; set; }

        public virtual Product product { get; set; }

        [Range(0, 5)]
        public int starts { get; set; }

        [Column(TypeName = "ntext")]
        public string contents { get; set; }

        public bool status { get; set; }

        public DateTime createdtime { get; set; }

        public DateTime deletedtime { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string deletedby { get; set; }
    }
}
