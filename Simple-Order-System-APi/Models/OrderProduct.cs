using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml;

namespace Simple_Order_System_APi.Models
{
    [Table("tb_tr_order_products")]
    public class OrderProduct
    {
        [Key, Column("id", TypeName = "nchar(11)")]
        public int Id { get; set; }

        [Required, Column("qty")]
        public int Qty { get; set; }

<<<<<<< HEAD
        [Range(0,13), Required, Column("price_each")]
        public int PriceEach { get; set; }
=======
        [Range(0, 13), Required, Column("price_each")]
        public int priceEach { get; set; }
>>>>>>> rama

        [Column("order_id")]
        public int OrderId { get; set; }

        [Column("product_code")]
        public int ProductCode { get; set; }

        //Cardinality
        [JsonIgnore]
<<<<<<< HEAD
        [ForeignKey(nameof(OrderId))]
        public ICollection<Order>? Orders { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(ProductCode))]
        public ICollection<ProductLine>? ProductLines { get; set; }
=======
        [ForeignKey(nameof(orderId))]
        public Order? order { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(productCode))]
        public Product product { get; set; }
>>>>>>> rama
    }

}
