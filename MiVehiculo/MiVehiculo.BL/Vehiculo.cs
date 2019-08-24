using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiVehiculo.BL
{
   public  class Vehiculo
    {       
        public int Id { get; set; }
        public String Marca { get; set; }
        //public int Marca { get; set; }
        public String Modelo { get; set; }
        public String Placa { get; set; }
        public int Año { get; set; }
        public String Color { get; set; }
        public String Estatus { get; set; } 
    }
}
