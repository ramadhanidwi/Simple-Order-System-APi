using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System.Text.Json.Serialization;

namespace Simple_Order_System_APi.Models
{
    [Table("tb_m_rma_payments")]
    public class Payment
    {
        [Key, Column("check_num", TypeName = "nvarchar(10)")]
        public int check_num { get; set; }

        [Required, Column("payment_date")]
        public DateTime payment_date { get; set; }

        [Required, Range(0, 13), Column("ammount")]
        public int ammount { get; set; }

        [Column("customer_id")]
        public int customerId {get; set;}

        //Cardinality 
        [JsonIgnore]
        [ForeignKey(nameof(customerId))]
        public Customer customer { get; set; }
    }
}
