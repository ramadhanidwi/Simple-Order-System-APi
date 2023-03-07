using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simple_Order_System_APi.Models
{
    [Table("tb_m_rma_role")]
    public class Role
    {
        [Key, Column("id", TypeName ="nchar(11)")]
        public int id { get; set; }

        [Required, Column("name", TypeName ="nvarchar(50)")]
        public string name { get; set; }
    }
}
