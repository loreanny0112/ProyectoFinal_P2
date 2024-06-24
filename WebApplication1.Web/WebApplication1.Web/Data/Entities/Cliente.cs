using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Web.Data.Core;

namespace WebApplication1.Web.Data.Entities
{
    [Table("Cliente", Schema = "dbo")]
    public class Cliente : BaseEntity
    {
        [Key]
        public int IdCliente { get; set; }
        public char Nombre { get; set; }
        public char Telefono { get; set; }
        public char Email { get; set; }
    }
}
