using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Simple_Order_System_APi.Models
{
    [Table("tb_tr_account_roles")]
    public class AccountRole
    {
        [Key, Column("id")]
        public int Id { get; set; }
    }
}
