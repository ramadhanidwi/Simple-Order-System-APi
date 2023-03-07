using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Simple_Order_System_APi.Models
{
    [Table("tb_m_employees")]

    public class Employee
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Required, Column("office_code")]
        public int OfficeCode { get; set; }

        [Column("reports_to")]
        public int? ReportsTo { get; set; }

        [Required, Column("first_name"), MaxLength(50)]
        public string FirstName { get; set; }

        [Column("last_name"), MaxLength(50)]
        public string? LastName { get; set; }

        [Required, Column("email"), MaxLength(50)]
        public string Email { get; set; }

        [Required, Column("job_title"), MaxLength(30)]
        public string JobTitle { get; set; }

        //relasi
        [ForeignKey(nameof(OfficeCode))]

        //cardinality
        [JsonIgnore]
        public Office? Office { get; set; }

        [JsonIgnore]
        public Employee? ReportTo { get; set; }

        [JsonIgnore]
        ICollection<Customer>? Customers { get; set; }
        
    }

}
