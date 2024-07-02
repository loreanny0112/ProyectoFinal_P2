﻿namespace WebApplication1.Web.Data.Models.Cliente
{
    public abstract class ClienteBaseModel : ModelBase
    {
        public int IdCliente { get; set; }
        public string? Nombre { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
    }
}
