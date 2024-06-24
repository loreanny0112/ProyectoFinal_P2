namespace WebApplication1.Web.Data.Models.Empleado
{
    public abstract class EmpleadoBaseModel : ModelBase
    {
        public int IdEmpleado { get; set; }
        public char Nombre { get; set; }
        public char Cargo { get; set; }
    }
}
