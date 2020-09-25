using NewBankBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewBankWEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Post([Bind(Include = "cli_id,cli_identificacion,cli_apellido1,cli_apellido2,cli_nombre1,cli_nombre2,cli_direccion,cli_ciudad,cli_celular,cli_email")] Cliente cliente)
        {
            NewBankEntities db = new NewBankEntities();
            if (ModelState.IsValid)
            {
                db.Cliente.Add(cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cliente);
        }
    }
}