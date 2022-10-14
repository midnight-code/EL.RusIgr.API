using System.ComponentModel.DataAnnotations.Schema;

namespace EL.RusIgr.API.Model
{
    [Table("ri_Tip")]
    public class TipOtdelaModel : SchemaModel
    {
        [Column("id_otdel")]
        public int OtdelID { get; set; }
    }
}
