using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Web.Data.Core;

namespace WebApplication1.Web.Data.Entities
{
    [Table("Empleado", Schema = "dbo")]
    public class Empleado : BaseEntity
    {
        [Key]
        public int IdEmpleado { get; set; }
        public string? Nombre { get; set; }
        public string? Cargo { get; set; }
    }
}
