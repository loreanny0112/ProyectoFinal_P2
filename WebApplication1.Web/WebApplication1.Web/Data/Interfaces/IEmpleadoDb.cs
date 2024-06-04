using RestauranteMaMonolitica.web.Data.Models;
using WebApplication1.Web.Data.Entities;
using WebApplication1.Web.Data.Models;

namespace WebApplication1.Web.Data.Interfaces
{
    public interface IEmpleadoDb
    {
        void saveEmpleado(EmpleadoSaveModel empleado);
        void UpdateEmpleado(EmpleadoUpdateModel updateModel);

        void RemoveEmpleado();

        List<EmpleadoModel> GetEmpleados();

        EmpleadoModel GetEmpleado(int IdEmpleado);
    }
}
