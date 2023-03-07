using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace Simple_Order_System_APi.Models
{
    [Table("tb_m_customers")]
    public class Customer
    {
        [Key, Column("id", TypeName = "nchar(11)")]
        public int Id { get; set; }

        [Required, Column("first_name", TypeName ="nvarchar(50)")]
        public string FirstName { get; set; }

        [Column("last_name", TypeName = "nvarchar(50)")]
        public string? LastName { get; set; }

        [Required, Column("phone", TypeName = "nvarchar(15)")]
        public string Phone { get; set; }

        [Required, Column("address1", TypeName = "nvarchar(255)")]
        public string Address1 { get; set; }

        [Column("address2", TypeName = "nvarchar(255)")]
        public string? Address2 { get; set; }

        [Required, Column("city", TypeName = "nvarchar(50)")]
        public string City { get; set; }

        [Required, Column("state", TypeName = "nvarchar(50)")]
        public string State { get; set; }

        [Required, Column("postal_code", TypeName = "nvarchar(10)")]
        public string PostalCode { get; set; }

        [Required, Column("country", TypeName = "nvarchar(50)")]
        public string Country { get; set; }

        [Column("employee_id", TypeName="nchar(11)")]
        public int EmployeeId { get; set; }

<<<<<<< HEAD
        //relasi
        [ForeignKey(nameof(EmployeeId))]

        //cardinality

        [JsonIgnore]
        public Employee? Employee { get; set; }

        [JsonIgnore]
        public Order? Order { get; set; }

        [JsonIgnore]
        public Payment? Payment { get; set; }
=======
        //cardinality
        [JsonIgnore]
        public ICollection<Order>? orders { get; set; }

        [JsonIgnore]
        public ICollection<Payment>? payments { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(employee_id))]
        public Employee? employee { get; set; }
>>>>>>> rama
    }
}
