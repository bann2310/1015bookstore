using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1015bookstore.model.Abstract
{
    public class Auditable
    {
        [Required]
        public DateTime createdtime {  get; set; }
        [Required]
        public DateTime[] updatedtime { get; set; }
        [Required]
        public bool status { get; set; }

        public Auditable() {
            createdtime = DateTime.Now;
        }

    }
}
