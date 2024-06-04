using RestauranteMaMonolitica.web.Data.Models;
using WebApplication1.Web.Data.Context;
using WebApplication1.Web.Data.Interfaces;
using WebApplication1.Web.Data.Models;

namespace WebApplication1.Web.Data.DBObjects
{
    public class ClienteDb : IClienteDb
    {
        private readonly RestauranteContext context;

        public ClienteDb(RestauranteContext context)
        {
            this.context = context;
        }
        public ClienteModel GetCliente(int IdCliente)
        {
            throw new NotImplementedException();
        }

        public List<ClienteModel> GetClientes()
        {
            throw new NotImplementedException();
        }

        public void RemoveCliente()
        {
            throw new NotImplementedException();
        }

        public void saveCliente(ClienteSaveModel cliente)
        {
            throw new NotImplementedException();
        }

        public void UpdateCliente(ClienteUpdateModel updateModel)
        {
            throw new NotImplementedException();
        }
    }
}
