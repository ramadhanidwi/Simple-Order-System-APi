using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Simple_Order_System_APi.Models
{
    [Table("tb_m_products")]
    public class Product
    {
        [Key, Column("code")]
        public int Code { get; set; }

        [Required, Column("productline_id")]
        public int ProductlineId { get; set; }

        [Required, Column("name"), MaxLength(100)]
        public string Name { get; set; }

        [Required, Column("scale")]
        public int Scale { get; set; }

        [Required, Column("vendor"), MaxLength(50)]
        public string Vendor { get; set; }

        [Required, Column("pdt_description")]
        public string ProductDescription { get; set; }

        [Required, Column("qty_in_stock")]
        public int QtyInStock { get; set; }

        [Required, Column("buy_price")]
        public int  BuyPrice { get; set; }

        [Required, Column("msrp"), MaxLength(50)]
        public string MSRP { get; set; }

        //relasi
        [ForeignKey(nameof(ProductlineId))]
        [JsonIgnore]
        public ProductLine? ProductLine { get; set; }
        /*[JsonIgnore]
        public ICollection<OrderProduct>? OrderProducts { get; set; }*/
    }
}
