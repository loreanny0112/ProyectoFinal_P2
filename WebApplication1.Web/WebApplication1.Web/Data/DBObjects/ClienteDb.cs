﻿using WebApplication1.Web.Data.Models;
using WebApplication1.Web.Data.Context;
using WebApplication1.Web.Data.Entities;
using WebApplication1.Web.Data.Exceptions;
using WebApplication1.Web.Data.Interfaces;
using WebApplication1.Web.Data.Models;
using WebApplication1.Web.Data.Models.Cliente;

namespace WebApplication1.Web.Data.DBObjects
{
    public class ClienteDb : IClienteDb
    {
        private readonly RestauranteContext context;

        public ClienteDb(RestauranteContext context)
        {
            this.context = context;
        }
        public ClienteGetModel GetCliente(int IdCliente)
        {
            var cliente = this.context.Clientes.Find(IdCliente);
            ClienteGetModel clienteModel = new ClienteGetModel()
            {
               
                IdCliente = cliente.IdCliente,
                Nombre = cliente.Nombre,
                Telefono = cliente.Telefono,
                Email = cliente.Email,
            };
            return clienteModel;
        }

            public List<ClienteGetModel> GetClientes()
            {
                return this.context.Clientes.Select(cliente => new ClienteGetModel()
                {
                    IdCliente = cliente.IdCliente,
                    Nombre = cliente.Nombre,
                    Telefono = cliente.Telefono,
                    Email = cliente.Email,
                }).ToList();
            }
            

        public void RemoveCliente()
        {
            throw new NotImplementedException();
        }

        public void RemoveCliente(ClienteRemoveModel clienteRemove)
        {
            Cliente clienteToDelete = this.context.Clientes.Find(clienteRemove.IdCliente);
        }

        public void saveCliente(ClienteSaveModel clienteSave)
        {
            Cliente cliente = new Cliente()

            {
                IdCliente = clienteSave.IdCliente,
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
            clienteToUpdate.IdCliente = updateModel.IdCliente;
            clienteToUpdate.Nombre = updateModel.Nombre;
            clienteToUpdate.Telefono = updateModel.Telefono;
            clienteToUpdate.Email = updateModel.Email;

            this.context.Clientes.Update(clienteToUpdate);
            this.context.SaveChanges();
        }
    }
}
