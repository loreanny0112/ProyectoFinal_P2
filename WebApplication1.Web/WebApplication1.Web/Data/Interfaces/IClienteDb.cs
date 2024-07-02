using WebApplication1.Web.Data.Models;
using WebApplication1.Web.Data.Entities;
using WebApplication1.Web.Data.Models;
using WebApplication1.Web.Data.Models.Cliente;
using WebApplication1.Web.BL.Services;

namespace WebApplication1.Web.Data.Interfaces
{
    public interface IClienteDb
    {
        void saveCliente(ClienteSaveModel cliente);
        void UpdateCliente(ClienteUpdateModel updateModel);

        void RemoveCliente(ClienteRemoveModel clienteRemove);
   
        List<ClienteGetModel> GetClientes();

        ClienteGetModel GetCliente(int IdCliente);  
    }
}
