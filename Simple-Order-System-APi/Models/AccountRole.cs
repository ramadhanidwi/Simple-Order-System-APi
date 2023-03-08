using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Simple_Order_System_APi.Models
{
    [Table("tb_tr_account_roles")]
    public class AccountRole
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Required, Column("account_id")]
        public string AccountId { get; set; }

        [Required, Column("role_id")]
        public int RoleId { get; set; }


        //relasi
        [ForeignKey(nameof(AccountId))]
        //cardinality
        [JsonIgnore]
        public Account? Account { get; set; }

        //relasi
        [ForeignKey(nameof(RoleId))]
        //cardinality
        [JsonIgnore]
        public Role? Role { get; set; }
    }
}
