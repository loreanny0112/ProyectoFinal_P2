namespace WebApplication1.Web.Data.Models.Cliente
{
    public abstract class ClienteBaseModel : ModelBase
    {
        public int IdCliente { get; set; }
        public char Telefono { get; set; }
        public char Email { get; set; }
    }
}
