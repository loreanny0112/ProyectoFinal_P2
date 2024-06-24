using Microsoft.EntityFrameworkCore;
using WebApplication1.Web.Data.Entities;

namespace WebApplication1.Web.Data.Context
{
    public class RestauranteContext : DbContext
    {

        public RestauranteContext(DbContextOptions<RestauranteContext> options) :base(options) 
        {
        }
        #region"Db Sets"
        public DbSet<Cliente>Clientes{ get; set; }
        public DbSet<Empleado>Empleados{ get; set; }
        #endregion
    }
}
