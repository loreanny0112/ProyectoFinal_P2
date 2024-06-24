using WebApplication1.Web.Data.Models;
using WebApplication1.Web.Data.Entities;
using WebApplication1.Web.Data.Models.Empleado;

namespace WebApplication1.Web.Data.Interfaces
{
    public interface IEmpleadoDb
    {
        void saveEmpleado(EmpleadoSaveModel empleado);
        void UpdateEmpleado(EmpleadoUpdateModel updateModel);

        void RemoveEmpleado(EmpleadoRemoveModel empleadoRemove);

        List<EmpleadoGetModel> GetEmpleados();

        EmpleadoGetModel GetEmpleado(int IdEmpleado);
    }
}
