using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiVehiculo.BL
{
   public class Marca
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ingrese la Marca")]
        public String Descripcion { get; set; }
        public String Observacion { get; set; }
        
    }
}
