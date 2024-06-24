using WebApplication1.Web.Data.Models.Cliente;

namespace WebApplication1.Web.Data.Models
{
    public class ClienteSaveModel : ClienteBaseModel
    {
        public char Nombre { get; internal set; }
    }
}
