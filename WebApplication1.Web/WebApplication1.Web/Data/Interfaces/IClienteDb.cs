using RestauranteMaMonolitica.web.Data.Models;
using WebApplication1.Web.Data.Entities;
using WebApplication1.Web.Data.Models;

namespace WebApplication1.Web.Data.Interfaces
{
    public interface IClienteDb
    {
        void saveCliente(ClienteSaveModel cliente);
        void UpdateCliente(ClienteUpdateModel updateModel);

        void RemoveCliente();

        List<ClienteModel> GetClientes();

        ClienteModel GetCliente(int IdCliente);  
    }
}
