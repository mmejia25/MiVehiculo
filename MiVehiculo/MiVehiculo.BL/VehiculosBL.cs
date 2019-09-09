using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiVehiculo.BL
{
    public class VehiculosBL
    {
        Contexto _contexto;
        public List<Vehiculo> ListadeVehiculos { get; set; }
        public VehiculosBL()
        {
            _contexto = new Contexto();
            ListadeVehiculos = new List<Vehiculo>();
        }

        public List<Vehiculo> Obtener()
        {
            ListadeVehiculos = _contexto.Vehiculos
                .Include("Marca")
                 .ToList();
                
            return ListadeVehiculos;
        }
        public void GuardarVehiculo(Vehiculo vehiculo)
        {
            if(vehiculo.Id == 0)
            {
                _contexto.Vehiculos.Add(vehiculo);
                
            }else
            {
                var vehiculoexistente = _contexto.Vehiculos.Find(vehiculo.Id);
                vehiculoexistente.Marca = vehiculo.Marca;
                vehiculoexistente.MarcaId = vehiculo.MarcaId;
                vehiculoexistente.Placa = vehiculo.Placa;
                vehiculoexistente.Modelo = vehiculo.Modelo;
                vehiculoexistente.Año = vehiculo.Año;
                vehiculoexistente.UrlImagen = vehiculo.UrlImagen;
            }

        
            _contexto.SaveChanges();

        }

        public Vehiculo Obtener(int Id)
        {
            var vehiculo = _contexto.Vehiculos.Find(Id);
            return vehiculo;
        }

        public void EliminarVehiculo(int Id)
        {
            var vehiculo = _contexto.Vehiculos.Find(Id);

            _contexto.Vehiculos.Remove(vehiculo);
            _contexto.SaveChanges();
        }
    }
}
