using MiVehiculo.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiVehiculo.WebAdmin.Controllers
{
    public class MarcasController : Controller
    {

        MarcasBL _marcasBL;

        public MarcasController()
        {

            _marcasBL = new MarcasBL();

        }
        // GET: Marcas
        public ActionResult Index()
        {

            var ListadeMarcas = _marcasBL.Obtener();
            return View(ListadeMarcas);
        }

        public ActionResult Crear()
        {
            var NuevaMarca = new Marca();

            return View(NuevaMarca);
        }


        [HttpPost]
        public ActionResult Crear(Marca marca)
        {

            _marcasBL.GuardarMarca(marca);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int Id)
        {
            var marca = _marcasBL.Obtener(Id);
            return View(marca);
        }

        [HttpPost]
        public ActionResult Editar(Marca marca)
        {
            _marcasBL.GuardarMarca(marca);
            return RedirectToAction("Index");
        }

        public ActionResult Detalle(int Id)
        {
            var marca = _marcasBL.Obtener(Id);

            return View(marca);
        }

        public ActionResult Eliminar(int Id)
        {
            var marca = _marcasBL.Obtener(Id);

            return View(marca);
        }

        [HttpPost]
        public ActionResult Eliminar(Marca marca)
        {
            _marcasBL.EliminarMarca(marca.Id);
            return RedirectToAction("Index");
        }
    }
}