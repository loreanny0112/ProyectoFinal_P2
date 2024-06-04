using WebApplication1.Web.Data.Core;

namespace WebApplication1.Web.Data.Entities
{
    public class Cliente : BaseEntity
    {
        public int IdCliente { get; set; }
        public char Nombre { get; set; }
        public char Telefono { get; set; }
        public char Email { get; set; }
    }
}
