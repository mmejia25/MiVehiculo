using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "Ingrese el Modelo")]
        [MinLength(4,ErrorMessage ="Ingrese Minimo 3 Caracteres")]
        [MaxLength(15, ErrorMessage ="Maximo 15 Caracteres")]
        public String Modelo { get; set; }

        [Required(ErrorMessage = "Ingrese la Placa")]
        [MinLength(4, ErrorMessage = "Ingrese Minimo 3 Caracteres")]
        public String Placa { get; set; }
        [Required(ErrorMessage = "Ingrese el Año del Vehiculo")]
        [Range(2000,3000, ErrorMessage = "Ingrese el Año del 2001 al 3000")]
        public int Año { get; set; }
        [Required(ErrorMessage = "Ingrese el Color")]
        public String Color { get; set; }
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }

        [Display(Name = "Imagen")]
        public String UrlImagen { get; set; }

        public bool Estatus { get; set; } 

    }
}
