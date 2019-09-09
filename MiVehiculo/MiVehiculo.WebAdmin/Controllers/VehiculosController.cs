using MiVehiculo.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiVehiculo.WebAdmin.Controllers
{
    public class VehiculosController : Controller
    {

        VehiculosBL _vehiculosBL;
        MarcasBL _marcaBL;

        public VehiculosController()
        {

            _vehiculosBL = new VehiculosBL();
            _marcaBL = new MarcasBL();

        }
        // GET: Vehiculos
        public ActionResult Index()
        {

            var listadevehiculos = _vehiculosBL.Obtener();
            return View(listadevehiculos);
        }

        public ActionResult Crear()
        {
            var NuevoVehiculo = new Vehiculo();
            var marcas = _marcaBL.Obtener();

            ViewBag.MarcaId = new SelectList(marcas, "Id", "Descripcion");
            return View(NuevoVehiculo);
        }


        [HttpPost]
        public ActionResult Crear(Vehiculo vehiculo, HttpPostedFileBase imagen)
        {

            if (ModelState.IsValid)
            {

                if (vehiculo.MarcaId == 0)
                {
                    ModelState.AddModelError("MarcaId", "Seleccione una Marca");
                    return View(vehiculo);

                }

                if (imagen != null)
                {
                    vehiculo.UrlImagen = GuardarImagen(imagen);
                }

                _vehiculosBL.GuardarVehiculo(vehiculo);

                return RedirectToAction("Index");

            }

            var NuevoVehiculo = new Vehiculo();
            var marcas = _marcaBL.Obtener();

            ViewBag.MarcaId = new SelectList(marcas, "Id", "Descripcion");
            return View(NuevoVehiculo);
        }

        public ActionResult Editar(int Id)

        {
           var vehiculos = _vehiculosBL.Obtener(Id);
            var marcas = _marcaBL.Obtener();

            ViewBag.MarcaId = new SelectList(marcas, "Id", "Descripcion", vehiculos.MarcaId);
            
            return View(vehiculos);
        } 
        
        [HttpPost]
        public ActionResult Editar(Vehiculo vehiculo, HttpPostedFileBase imagen)
        {
            if (ModelState.IsValid)
            {

                if (vehiculo.MarcaId == 0)
                {
                    ModelState.AddModelError("MarcaId", "Seleccione una Marca");
                    return View(vehiculo);

                }

                if (imagen != null)
                {
                    vehiculo.UrlImagen = GuardarImagen(imagen);
                }

                _vehiculosBL.GuardarVehiculo(vehiculo);

                return RedirectToAction("Index");

            }

            _vehiculosBL.GuardarVehiculo(vehiculo);
            return RedirectToAction("Index");
        }

        public ActionResult Detalle(int Id)
        {
            var vehiculo = _vehiculosBL.Obtener(Id);

            return View(vehiculo);
        }

        public ActionResult Eliminar(int Id)
        {
            var vehiculo = _vehiculosBL.Obtener(Id);

            return View(vehiculo);
        }

        [HttpPost]
        public ActionResult Eliminar(Vehiculo vehiculo)
        {
            _vehiculosBL.EliminarVehiculo(vehiculo.Id);
            return RedirectToAction("Index");
        }

        private string GuardarImagen(HttpPostedFileBase imagen)
        {
            string path = Server.MapPath("~/Imagenes/" + imagen.FileName);
            imagen.SaveAs(path);

            return "/Imagenes/" + imagen.FileName;
        }
    }
}