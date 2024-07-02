﻿using WebApplication1.Web.Data.Models.Empleado;

namespace WebApplication1.Web.Data.Models.Empleado

{
    public class EmpleadoUpdateModel : EmpleadoBaseModel
    {
        public int IdEmpleado { get; set; }
        public string? Nombre { get; set; }
        public string? Cargo { get; set; }
    }
}
