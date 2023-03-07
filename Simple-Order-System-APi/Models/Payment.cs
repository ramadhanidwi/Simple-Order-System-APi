using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System.Text.Json.Serialization;

namespace Simple_Order_System_APi.Models
{
    [Table("tb_m_payments")]
    public class Payment
    {
        [Key, Column("check_num", TypeName = "nvarchar(10)")]
        public int CheckNum { get; set; }

        [Required, Column("payment_date")]
        public DateTime PaymentDate { get; set; }

        [Required, Range(0, 13), Column("amount")]
        public int Amount { get; set; }

        [Column("customer_id")]
        public int CustomerId {get; set;}

        
        //relasi
        [ForeignKey(nameof(CustomerId))]

        //Cardinality 
        [JsonIgnore]
        public Customer? Customer { get; set; }

    }
}
