using WebApplication1.Web.BL.Core;
using WebApplication1.Web.Data.Models;
using WebApplication1.Web.Data.Models.Cliente;

namespace WebApplication1.Web.BL.Interfaces
{
    public interface IClienteService 
    {
        ServiceResult GetClientes();
        ServiceResult GetCliente(int id);

        ServiceResult UpdateClientes(ClienteUpdateModel clienteUpdate);

        ServiceResult RemoveClientes(ClienteRemoveModel clienteRemove);

        ServiceResult SaveClientes(ClienteSaveModel clienteSave);
    }
}
