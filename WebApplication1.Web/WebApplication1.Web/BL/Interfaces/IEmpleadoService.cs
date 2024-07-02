using WebApplication1.Web.Data.Models;
using WebApplication1.Web.Data.Models.Empleado;
using WebApplication1.Web.BL.Core;

namespace WebApplication1.Web.BL.Interfaces
{
    public interface IEmpleadoService
    {
        ServiceResult GetEmpleados();
        ServiceResult GetEmpleados(int id);

        ServiceResult UpdateEmpleados(EmpleadoUpdateModel empleadoUpdate);

        ServiceResult RemoveEmpleados(EmpleadoRemoveModel empleadoRemove);

        ServiceResult SaveEmpleados(EmpleadoSaveModel empleadoSave);
    }
}
