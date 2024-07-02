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
        public string? Nombre { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
    }
}
