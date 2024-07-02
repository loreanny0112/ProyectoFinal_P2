﻿namespace WebApplication1.Web.Data.Models.Empleado
{
    public abstract class EmpleadoBaseModel : ModelBase
    {
        public int IdEmpleado { get; set; }
        public string? Nombre { get; set; }
        public string? Cargo { get; set; }
    }
}
