using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Simple_Order_System_APi.Models
{
    [Table("tb_m_offices")]
    public class Office
    {
        [Key, Column("code")]
        public int Code { get; set; }

        [Required, Column("city"), MaxLength(50)]
        public string City { get; set; }

        [Required, Column("phone"), MaxLength(15)]
        public string Phone { get; set; }

        [Required, Column("address1")]
        public string Address1 { get; set; }

        [Column("address2")]
        public string? Address2 { get; set; }

        [Required, Column("state"), MaxLength(50)]
        public string State { get; set; }

        [Required, Column("country"), MaxLength(50)]
        public string Country { get; set; }

        [Required, Column("postal_code"), MaxLength(10)]
        public string PostalCode { get; set; }

        //cardinality
        [JsonIgnore]
        public ICollection<Employee>? Employees { get; set; }
    }
}
