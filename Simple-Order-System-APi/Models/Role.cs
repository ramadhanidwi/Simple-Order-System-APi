using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Simple_Order_System_APi.Models
{
    [Table("tb_m_role")]
    public class Role
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Required, Column("name")]
        public string Name { get; set; }

        //cardinality
        [JsonIgnore]
        public ICollection<AccountRole>? AccountRoles { get; set; }
    }
}
