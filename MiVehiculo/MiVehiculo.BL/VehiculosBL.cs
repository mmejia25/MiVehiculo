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

           return _contexto.Vehiculos.ToList();
        }
    }
}
