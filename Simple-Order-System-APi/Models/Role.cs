using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Simple_Order_System_APi.Models
{
    [Table("tb_m_role")]
    public class Role
    {
        [Key, Column("id", TypeName ="nchar(11)")]
        public int Id { get; set; }

        [Required, Column("name", TypeName ="nvarchar(50)")]
        public string Name { get; set; }

        //cardinality
        [JsonIgnore]
        public ICollection<AccountRole>? AccountRoles { get; set; }
    }
}
