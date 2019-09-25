using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiVehiculo.BL;


namespace MiVehiculo.Web.Controllers
{
    public class HomeController : Controller
    {



        // GET: Home
        public ActionResult Index()
        {

            var productosBL = new ProductosBL();
            var listadeproductos = productosBL.ObtenerProductosActivos();

          ViewBag.adminwebSiteUrl = ConfigurationManager.AppSettings["adminwebSiteUrl"];

            return View(listadeproductos);

        }
    }
}