using MiVehiculo.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiVehiculo.Web.Controllers
{
    public class VehiculosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var vehiculosBL = new VehiculosBL();

            var listadevehiculos = vehiculosBL.Obtener();
            return View(listadevehiculos);
        }
    }
}