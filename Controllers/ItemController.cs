using Modelo;
using Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AluguelTemasWebApp.Controllers
{
    public class ItemController : Controller
    {
        private ItemServico itemServico = new ItemServico();
        // GET: Item
        public ActionResult Index()
        {
            return View();
        }
        private ActionResult GravarItem(ItemTema item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    itemServico.GravarItem(item);
                    return RedirectToAction("Index");
                }
                return View(item);
            }
            catch
            {
                return View(item);
            }
        }
        // GET: Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ItemTema item)
        {
            return GravarItem(item);
        }
    }
}