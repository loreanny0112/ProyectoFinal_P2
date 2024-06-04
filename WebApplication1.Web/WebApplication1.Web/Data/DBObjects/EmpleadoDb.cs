﻿using RestauranteMaMonolitica.web.Data.Models;
using WebApplication1.Web.Data.Context;
using WebApplication1.Web.Data.Entities;
using WebApplication1.Web.Data.Exceptions;
using WebApplication1.Web.Data.Interfaces;
using WebApplication1.Web.Data.Models;
namespace WebApplication1.Web.Data.DBObjects
{
    public class EmpleadoDb : IEmpleadoDb
    {
        private readonly RestauranteContext context;

        public EmpleadoDb(RestauranteContext context)
        {
            this.context = context;
        }
        public EmpleadoModel GetEmpleado(int IdEmpleado)
        {
            var empleado = this.context.Empleados.Find(IdEmpleado);
            EmpleadoModel empleadoModel = new EmpleadoModel()
            {
                Nombre = empleado.Nombre,
                Cargo = empleado.Cargo,
            };
            return empleadoModel;
        }

        public List<EmpleadoModel> GetEmpleados()
        {
            return this.context.Empleados.Select(empleado => new EmpleadoModel()
            {
                Nombre = empleado.Nombre,
                Cargo = empleado.Cargo,
            }).ToList();
        }

        public void RemoveEmpleado()
        {
            throw new NotImplementedException();
        }

        public void saveEmpleado(EmpleadoSaveModel empleadoSave)
        {
            Empleado empleado = new Empleado() 

            {

               
                Nombre = empleadoSave.Nombre,
                Cargo = empleadoSave.Cargo,
            };
            this.context.Empleados.Add(empleado);
            this.context.SaveChanges(); 
        }

        public void UpdateEmpleado(EmpleadoUpdateModel updateModel)
        {
            Empleado empleadoToUpdate = this.context.Empleados.Find(updateModel.IdEmpleado);
            if (empleadoToUpdate == null)
            {
                throw new EmpleadoDbException("El empleado no se encuentra registrado.");
            }
            empleadoToUpdate.Nombre = updateModel.Nombre;
            empleadoToUpdate.Cargo = updateModel.Cargo;

            this.context.Empleados.Update(empleadoToUpdate);
            this.context.SaveChanges();
        }
    }
}