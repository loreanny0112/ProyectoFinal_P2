using RestauranteMaMonolitica.web.Data.Models;
using WebApplication1.Web.Data.Context;
using WebApplication1.Web.Data.Entities;
using WebApplication1.Web.Data.Exceptions;
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
            var cliente = this.context.Clientes.Find(IdCliente);
            ClienteModel clienteModel = new ClienteModel()
            {
                Nombre = cliente.Nombre,
                Telefono = cliente.Telefono,
                Email = cliente.Email,
            };
            return clienteModel;
        }

            public List<ClienteModel> GetClientes()
            {
                return this.context.Clientes.Select(cliente => new ClienteModel()
                {
                    Nombre = cliente.Nombre,
                    Telefono = cliente.Telefono,
                    Email = cliente.Email,
                }).ToList();
            }
            

        public void RemoveCliente()
        {
            throw new NotImplementedException();
        }

        public void saveCliente(ClienteSaveModel clienteSave)
        {
            Cliente cliente = new Cliente()

            {
                Nombre = clienteSave.Nombre,
                Telefono = clienteSave.Telefono,
                Email = clienteSave.Email,
            };
            this.context.Clientes.Add(cliente);
            this.context.SaveChanges(); ;
        }

        public void UpdateCliente(ClienteUpdateModel updateModel)
        {
            Cliente clienteToUpdate = this.context.Clientes.Find(updateModel.IdCliente);
            if (clienteToUpdate == null)
            {
                throw new EmpleadoDbException("El cliente no se encuentra registrado.");
            }
            clienteToUpdate.Nombre = updateModel.Nombre;
            clienteToUpdate.Telefono = updateModel.Telefono;
            clienteToUpdate.Email = updateModel.Email;

            this.context.Clientes.Update(clienteToUpdate);
            this.context.SaveChanges();
        }
    }
}
