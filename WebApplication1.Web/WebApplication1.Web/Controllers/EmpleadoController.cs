using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Web.BL.Interfaces;
using WebApplication1.Web.Data.Context;
using WebApplication1.Web.Data.DBObjects;
using WebApplication1.Web.Data.Interfaces;
using WebApplication1.Web.Data.Models.Cliente;
using WebApplication1.Web.Data.Models.Empleado;

namespace WebApplication1.Web.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly IClienteService clienteService;
        private IEmpleadoService empleadoService;

        public EmpleadoController(IEmpleadoService empleadoService)
        {
            this.empleadoService = empleadoService;
        }
        // GET: EmpleadoController1
        public ActionResult Index()
        {
            var result = this.empleadoService.GetEmpleados();
            if (!result.Success)

                ViewBag.Message = result.Message;

            var clientes = (List<EmpleadoGetModel>)result.Data;

            return View(clientes);
        }

        // GET: EmpleadoController1/Details/5
        public ActionResult Details(int id)
        {
            var empleado = this.empleadoService.GetEmpleados(id);
            return View(empleado);
        }

        // GET: EmpleadoController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpleadoController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmpleadoSaveModel empleadoSave)
        {
            try
            {
                this.empleadoService.SaveEmpleados(empleadoSave);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoController1/Edit/5
        public ActionResult Edit(int id)
        {
            var empleado = this.empleadoService.GetEmpleados(id);
            return View(empleado);
        }

        // POST: EmpleadoController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmpleadoUpdateModel empleadoUpdate)
        {
            try
            {
                this.empleadoService.UpdateEmpleados(empleadoUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpleadoController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
