﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml;

namespace Simple_Order_System_APi.Models
{
    [Table("tb_m_order_products")]
    public class OrderProduct
    {
        [Key, Column("id", TypeName = "nchar(11)")]
        public int Id { get; set; }

        [Required, Column("qty")]
        public int qty { get; set; }

        [Range(0,13), Required, Column("price_each")]
        public int priceEach { get; set; }

        [Column("order_id")]
        public int orderId { get; set; }

        [Column("product_code")]
        public int productCode { get; set; }

        //Cardinality
        [JsonIgnore]
        [ForeignKey("orderId")]
        public ICollection<Order> orders { get; set; }

        //[JsonIgnore]
        //[ForeignKey("productCode")]
        //public ICollection<ProductLine> productLines { get; set; }
    }
}