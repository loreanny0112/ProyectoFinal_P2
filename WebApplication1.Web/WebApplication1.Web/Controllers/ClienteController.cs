using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Web.BL.Core;
using WebApplication1.Web.BL.Interfaces;
using WebApplication1.Web.Data.Context;
using WebApplication1.Web.Data.Interfaces;
using WebApplication1.Web.Data.Models;
using WebApplication1.Web.Data.Models.Cliente;


namespace WebApplication1.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService clienteService;

        public ClienteController(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }
        // GET: ClienteController
        public ActionResult Index()
        {
            var result = clienteService.GetClientes();
            if (!result.Success)
            
                ViewBag.Message = result.Message;

            var clientes = (List<ClienteGetModel>)result.Data;

            return View(clientes);
        }

        // GET: ClienteController1/Details/5
        public ActionResult Details(int id)
        {
           
            var cliente = this.clienteService.GetCliente(id);
            if (!cliente.Success)
            {
                ViewBag.Message = cliente.Message;
                return View(new ClienteGetModel());
            }
            return View(cliente);
        }

        // GET: ClienteController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteSaveModel clienteSave)
        {
            try
            {
                this.clienteService.SaveClientes(clienteSave);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController1/Edit/5
        public ActionResult Edit(int id)
        {
            var cliente = this.clienteService.GetCliente(id);
           
            if (!cliente.Success)
            {
                ViewBag.Message = cliente.Message;
                return View(new ClienteGetModel());
            }
            return View(cliente);
            
        }

        // POST: ClienteController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteUpdateModel clienteUpdate)
        {
            try
            {
                this.clienteService.UpdateClientes(clienteUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClienteController1/Delete/5
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
