using WebApplication1.Web.BL.Core;
using WebApplication1.Web.BL.Interfaces;
using WebApplication1.Web.Data.Interfaces;
using WebApplication1.Web.Data.Models;
using WebApplication1.Web.Data.Models.Cliente;
using WebApplication1.Web.Data.Models.Empleado;

namespace WebApplication1.Web.BL.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly IEmpleadoDb empleadoDb;
        private readonly ILogger<EmpleadoService> logger;
        public EmpleadoService(IEmpleadoDb empleadoDb, ILogger<EmpleadoService> logger)
        
        {
            this.empleadoDb = empleadoDb;
            this.logger = logger;
        }

        public ServiceResult GetEmpleados()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = empleadoDb.GetEmpleados();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error obteniendo los clientes";
                this.logger.LogError(result.Message, ex.ToString());

            }
            return result;
        }

        public ServiceResult GetEmpleados(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = this.empleadoDb.GetEmpleado(id);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error obteniendo a los empleados";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }
        public ServiceResult UpdateEmpleados(EmpleadoUpdateModel empleadoUpdate)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                if (string.IsNullOrEmpty(empleadoUpdate.Nombre))
                {
                    result.Success = false;
                    result.Message = "El nombre del Empleado es requerido";
                    return result;
                }
                if (empleadoUpdate.Nombre.Length > 50)
                {
                    result.Success = false;
                    result.Message = "El nombre del empleado es solo puede tener 50 caracteres";
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error actualizando los datos";
            }
            return result;
        }

        public ServiceResult RemoveEmpleados(EmpleadoRemoveModel empleadoRemove)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                if (empleadoRemove is null)
                {
                    result.Success = false;
                    result.Message = "";
                    return result;
                }
                this.empleadoDb.RemoveEmpleado(empleadoRemove);

            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = "Ocurrio un error actualizando los datos";

            }
            return result;
        }
        public ServiceResult SaveEmpleados(EmpleadoSaveModel empleadoSave)
        {
            ServiceResult result = new ServiceResult();
            try
            {

            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = "Ocurrio un error guardando los datos";

            }
            return result;
        }
    }
}