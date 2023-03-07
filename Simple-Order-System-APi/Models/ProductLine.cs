using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Simple_Order_System_APi.Models
{
    [Table("tb_m_productlines")]
    public class ProductLine
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Required, Column("name"), MaxLength(50)]
        public string Name { get; set; }

        //cardinality
        [JsonIgnore]
        public ICollection<Product>? Products { get; set; }
    }
}
