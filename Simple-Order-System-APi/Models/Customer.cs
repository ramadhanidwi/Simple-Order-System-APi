using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace Simple_Order_System_APi.Models
{
    [Table("tb_m_rma_customers")]
    public class Customer
    {
        [Key, Column("id", TypeName = "nchar(11)")]
        public int id { get; set; }

        [Required, Column("first_name", TypeName ="nvarchar(50)")]
        public string first_name { get; set; }

        [Column("first_name", TypeName = "nvarchar(50)")]
        public string last_name { get; set; }

        [Required, Column("phone", TypeName = "nvarchar(15)")]
        public string phone { get; set; }

        [Required, Column("address1", TypeName = "nvarchar(255)")]
        public string address1 { get; set; }

        [Column("address2", TypeName = "nvarchar(255)")]
        public string address2 { get; set; }

        [Required, Column("city", TypeName = "nvarchar(50)")]
        public string city { get; set; }

        [Required, Column("state", TypeName = "nvarchar(50)")]
        public string state { get; set; }

        [Required, Column("postal_code", TypeName = "nvarchar(10)")]
        public string postal_code { get; set; }

        [Required, Column("country", TypeName = "nvarchar(50)")]
        public string country { get; set; }

        [Column("employee_id", TypeName="nchar(11)")]
        public int employee_id { get; set; }

        //cardinality 
        //[JsonIgnore]
        //public ICollection<Employee> Employees { get; set; }

        [JsonIgnore]
        public Order order { get; set; }

        [JsonIgnore]
        public Payment payment { get; set; }
    }
}
