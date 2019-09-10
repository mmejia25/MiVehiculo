using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiVehiculo.BL
{
   public class Cliente
    {
        public Cliente()
        {
            Activo = false;
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese El nombre del cliente")]
        public String Nombre { get; set; }
        [MinLength(8,ErrorMessage ="Telefono debe Contener al Menos 8 Caracteres")]
        [MaxLength(12,ErrorMessage ="Telefono No debe de Exceder los 10 Caracteres")]
        public String Telefono { get; set; }
        [Required(ErrorMessage ="Ingrese la Direccion de Cliente")]
        public String Direccion { get; set; }
        public bool Activo { get; set; }
    }
}
