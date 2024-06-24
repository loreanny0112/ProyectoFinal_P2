using WebApplication1.Web.Data.Models.Empleado;

namespace WebApplication1.Web.Data.Models.Empleado
{
    public class EmpleadoSaveModel : EmpleadoBaseModel
    {
        public char Nombre { get; internal set; }
        public char Cargo { get; set; }
    }
}
