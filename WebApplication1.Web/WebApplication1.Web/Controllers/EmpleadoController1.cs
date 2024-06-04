using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Web.Data.Context;
using WebApplication1.Web.Data.DBObjects;
using WebApplication1.Web.Data.Interfaces;

namespace WebApplication1.Web.Controllers
{
    public class EmpleadoController1 : Controller
    {
        private readonly IEmpleadoDb empleadoDb;

        public EmpleadoController1(IEmpleadoDb empleadoDb)
        {
            this.empleadoDb = empleadoDb;
        }
        // GET: EmpleadoController1
        public ActionResult Index()
        {
            var empleados = this.empleadoDb.GetEmpleados();
            return View(empleados);
        }

        // GET: EmpleadoController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmpleadoController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpleadoController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: EmpleadoController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmpleadoController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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
