using System.ComponentModel.DataAnnotations.Schema;

namespace EL.RusIgr.API.Model
{
    public class SchemaModel
    {
        [Column("id")]
        public int ID { get; set; }
        [Column("name")]
        public string Name { get; set; } = string.Empty;
    }
}
