using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using NewBankWEB.Models;
using System.Net;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Owin;
using Microsoft.AspNet.Identity;



namespace NewBankWEB.Controllers
{
    public class HomeController : Controller
    {
        string url = "https://localhost:44315/Api/";

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Cliente cliente)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                var PostJob = client.PostAsJsonAsync<Cliente>("Fabrica", cliente);
                PostJob.Wait();
                var PostResult = PostJob.Result;

                if (PostResult.IsSuccessStatusCode)
                {
                    ViewBag.Info = "Gracias por Crear una cuenta con nosotros";
                    return RedirectToAction("Transacciones");
                }
                ModelState.AddModelError(string.Empty, "Error al Registrar");
            }
            return View();
        }

        [Authorize]
        public ActionResult Transacciones()
        {
            string Usuario = User.Identity.GetUserName();
            IEnumerable<Cliente> cliente = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                var ResponseTask = client.GetAsync("Fabrica/?Email=" + Usuario);
                ResponseTask.Wait();
                var result = ResponseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<Cliente>>();
                    readJob.Wait();
                    cliente = readJob.Result;
                }
                else
                {
                    cliente = Enumerable.Empty<Cliente>();
                    ModelState.AddModelError(string.Empty, "Error al consumir");
                    return View("Index");
                }
            }
            ViewBag.Usuario = Usuario;
            ViewBag.Cliente = cliente.FirstOrDefault().cli_apellido1 + " " + cliente.FirstOrDefault().cli_apellido2 + " " + cliente.FirstOrDefault().cli_nombre1;
            ViewBag.Identificacion = cliente.FirstOrDefault().cli_identificacion;
            int cli_id = cliente.FirstOrDefault().cli_id;
            ViewBag.mensaje = "Gracias por hacer parte de nuestro Banco";

            IEnumerable<Cuenta> cuenta = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                var ResponseTask = client.GetAsync("Cuenta/" + cli_id.ToString());
                ResponseTask.Wait();
                var result = ResponseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<Cuenta>>();
                    readJob.Wait();
                    cuenta = readJob.Result;
                }
                else
                {
                    cuenta = Enumerable.Empty<Cuenta>();
                    ModelState.AddModelError(string.Empty, "Error al consumir");
                    return View("Index");
                }
            }
            return View(cuenta);
        }
    


        public ActionResult About(string mensaje)
        {
            
            ViewBag.Message = mensaje;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}