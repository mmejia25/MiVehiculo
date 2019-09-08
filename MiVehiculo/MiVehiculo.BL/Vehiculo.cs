using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiVehiculo.BL
{


   public  class Vehiculo
    {
        public Vehiculo()
        {
            Estatus = true;
        }

        public int Id { get; set; }
        //public int Marca { get; set; }
        public String Modelo { get; set; }
        public String Placa { get; set; }
        public int Año { get; set; }
        public String Color { get; set; }
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
        public bool Estatus { get; set; } 

    }
}
