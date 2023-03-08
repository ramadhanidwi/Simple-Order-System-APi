using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace Simple_Order_System_APi.Models
{
    [Table("tb_m_customers")]
    public class Customer
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Required, Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string? LastName { get; set; }

        [Required, Column("phone")]
        public string Phone { get; set; }

        [Required, Column("address1")]
        public string Address1 { get; set; }

        [Column("address2")]
        public string? Address2 { get; set; }

        [Required, Column("city")]
        public string City { get; set; }

        [Required, Column("state")]
        public string State { get; set; }

        [Required, Column("postal_code")]
        public string PostalCode { get; set; }

        [Required, Column("country")]
        public string Country { get; set; }

        [Column("employee_id")]
        public string EmployeeId { get; set; }

        //relasi
        [ForeignKey(nameof(EmployeeId))]

        //cardinality
        [JsonIgnore]
        public Employee? Employee { get; set; }

        [JsonIgnore]
        public ICollection<Order>? Orders{ get; set; }

        [JsonIgnore]
        public ICollection<Payment>? Payments { get; set; }

    }
}
