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


        [Required, Column("price_each")]
        public int PriceEach { get; set; }


        [Column("order_id")]
        public int OrderId { get; set; }

        [Column("product_code")]
        public int ProductCode { get; set; }

        //Cardinality
        [JsonIgnore]
        [ForeignKey(nameof(OrderId))]
        public Order? order { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(ProductCode))]
        public Product product { get; set; }

    }

}
