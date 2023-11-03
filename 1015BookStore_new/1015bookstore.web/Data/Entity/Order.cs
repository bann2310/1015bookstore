using _1015bookstore.web.Data.Abstract;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _1015bookstore.web.Data.Entity
{
    public enum status_deliveried
    {
        isdeliveried = 1, notdeliveried = 0 
    }

    [Table("Orders")]
    public class Order : Auditable
    {
        public int id { get; set; }

        public DateTime orderdate { get; set; }

        public status_deliveried deliveried { get; set; }

        public DateTime? deliverydate { get; set; }

        public int user_id { get; set; }

        public virtual User user { get; set; }

        public int? address_id { get; set; }

        // Khóa ngoại với OrderDetail
        public virtual ICollection<OrderDetail> orderdetails { get; set; }

        public Order ()
        {
            deliveried = status_deliveried.notdeliveried;
            orderdetails = new List<OrderDetail> ();
        }
    }
}
