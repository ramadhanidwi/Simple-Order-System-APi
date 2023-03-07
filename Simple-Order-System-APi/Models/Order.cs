using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Simple_Order_System_APi.Models
{
    [Table("tb_m_orders")]
    public class Order
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Required, Column("order_date")]
        public DateTime OrderDate { get; set; }

        [Required, Column("shipped_date")]
        public DateTime ShippedDate { get; set; }

        [Required, Column("comments")]
        public string Comments { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        //relasi
        [ForeignKey(nameof(CustomerId))]

        //Cardinality 
        [JsonIgnore]
        public Customer? Customer { get; set; }
        [JsonIgnore]
        public ICollection<OrderProduct>? OrderProducts { get; set; }

        
    }
}
