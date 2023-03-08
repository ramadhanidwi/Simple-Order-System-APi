﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simple_Order_System_APi.Models
{
    [Table("tb_m_role")]
    public class Role
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Required, Column("name", TypeName ="nvarchar(50)")]
        public string Name { get; set; }

        //Cardinality
        public ICollection<AccountRole>? AccountRoles { get; set; }

    }
}
