using WebApplication1.Web.Data.Core;

namespace WebApplication1.Web.Data.Entities
{
    public class Empleado : BaseEntity
    {
        public int IdEmpleado { get; set; }
        public char Nombre { get; set; }
        public char Cargo { get; set; }
    }
}
